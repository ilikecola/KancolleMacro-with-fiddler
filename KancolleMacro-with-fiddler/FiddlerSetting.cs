using Codeplex.Data;
using KancolleMacro_with_fiddler.Models.Raws;
using System;
using System.Configuration;
using Newtonsoft.Json;

namespace KancolleMacro_with_fiddler
{
    class FiddlerSetting
    {
        private string listenport;
        private string upstreamport;
        //委托
        public delegate void LogControlThread(string str);
        public delegate void TimeControlThread(int index,long Unixtime);
        public event LogControlThread log2Box;
        public event TimeControlThread autotimer;

        public void initialization()
        {
            //
            //Fiddler设定
            //
            //port设定
            listenport = ConfigurationManager.AppSettings["listenPort"].ToString();
            upstreamport = ConfigurationManager.AppSettings["upstreamPort"].ToString();

            //上流プロキシの設定
            Fiddler.FiddlerApplication.BeforeRequest += new Fiddler.SessionStateHandler(FiddlerApplication_BeforeRequest);
            //クライアントへレスポンスを返した後に呼ばれるイベント
            Fiddler.FiddlerApplication.AfterSessionComplete
                            += new Fiddler.SessionStateHandler(FiddlerApplication_AfterSessionComplete);
            //Fiddlerを開始。ポートは自動選択
            Fiddler.FiddlerApplication.Startup(int.Parse(listenport), Fiddler.FiddlerCoreStartupFlags.ChainToUpstreamGateway);

            //当該プロセスのプロキシを設定する。WebBroweserコントロールはこの設定を参照
            Fiddler.URLMonInterop.SetProxyInProcess(string.Format("127.0.0.1:{0}",
                            Fiddler.FiddlerApplication.oProxy.ListenPort), "<local>");
            //label2.Text = Fiddler.FiddlerApplication.oProxy.ListenPort.ToString();
            if (log2Box != null)
            {
                log2Box("监听端口:" + listenport);
                log2Box("上流端口:" + upstreamport);
            }
                
        }

        private void FiddlerApplication_BeforeRequest(Fiddler.Session oSession)
        {
            if (int.Parse(upstreamport) != 0)
            {
                oSession["X-OverrideGateway"] = "127.0.0.1:"+ upstreamport;
            }          
            if (!oSession.PathAndQuery.StartsWith("/kcsapi/api_")) // 艦これのAPI以外は無視する
            {
                oSession.Ignore();
                return;
            }
            // 戦闘開始のタイミングのずれを防ぐためにバッファする
            if (oSession.PathAndQuery.EndsWith("api_req_sortie/battle") || oSession.PathAndQuery.EndsWith("api_req_practice/battle"))
                oSession.bBufferResponse = true;
        }

        private void FiddlerApplication_AfterSessionComplete(Fiddler.Session oSession)
        {
            //取り敢えずログを吐く
            Console.WriteLine(string.Format("Session {0}({3}):HTTP {1} for {2}",
                    oSession.id, oSession.responseCode, oSession.fullUrl, oSession.oResponse.MIMEType));
            sessionhandle(oSession);
        }

        private void sessionhandle(Fiddler.Session oSession)
        {
            if (oSession.PathAndQuery.EndsWith("/kcsapi/api_port/port"))
            {
                string JSON = oSession.GetResponseBodyAsString();
                JSON = JSON.Remove(0, "svdata=".Length);
                porthandle(JSON);
            }

            if (oSession.PathAndQuery.EndsWith("/kcsapi/api_get_member/mission"))
            {
                string JSON = oSession.GetResponseBodyAsString();
                JSON = JSON.Remove(0, "svdata=".Length);
                missionhandle(JSON);
            }

            if (oSession.PathAndQuery.EndsWith("/kcsapi/api_req_hokyu/charge"))
            {
                string JSON = oSession.GetResponseBodyAsString();
                JSON = JSON.Remove(0, "svdata=".Length);
                chargehandle(JSON);
            }

            if (oSession.PathAndQuery.EndsWith("/kcsapi/api_req_mission/result"))
            {
                string JSON = oSession.GetResponseBodyAsString();
                JSON = JSON.Remove(0, "svdata=".Length);
                resulthandle(JSON);
            }

            if (oSession.PathAndQuery.EndsWith("/kcsapi/api_req_mission/start"))
            {
                string JSON = oSession.GetResponseBodyAsString();
                JSON = JSON.Remove(0, "svdata=".Length);
                ExStarthandle(JSON);
            }
        }

        private void ExStarthandle(string JSON)
        {
            dynamic json = DynamicJson.Parse(JSON);
            if ((int)json.api_result == 1)
            {
                convarible.ExStart_api_result = 1;
            }
        }

        private void resulthandle(string JSON)
        {
            dynamic json = DynamicJson.Parse(JSON);
            if ((int)json.api_result == 1)
            {
                convarible.result_api_result = 1;
            }
        }

        private void porthandle(string JSON)
        {
            dynamic json_tree = DynamicJson.Parse(JSON);
            if ((int)json_tree.api_result == 1)
            {
                convarible.port_api_result = 1;
                dynamic result = json_tree.api_data;
                dynamic deck = result.api_deck_port;
                recordApiTime(JSON);
            }
        }

        private void recordApiTime(dynamic obj)
        {
            var kcsapi_port = JsonConvert.DeserializeObject<kcsapi_deck>(obj);
            for (int i = 0; i < 4; i++)
            {
                if(convarible.api_mission_time[i] != kcsapi_port.api_data.api_deck_port[i].api_mission[2])
                {
                    convarible.api_mission_time[i] = kcsapi_port.api_data.api_deck_port[i].api_mission[2];
                    autotimer(i, convarible.api_mission_time[i]);
                }
            }
        }

        private void chargehandle(string JSON)
        {
            dynamic json = DynamicJson.Parse(JSON);
            if ((int)json.api_result == 1)
            {
                convarible.charge_api_result = 1;
            }
        }

        private void missionhandle(string JSON)
        {
            dynamic json = DynamicJson.Parse(JSON);
            if ((int)json.api_result == 1)
            {
                convarible.mission_api_result = 1;
            }
        }

        public void listenportchange(int listenport_)
        {
            Fiddler.FiddlerApplication.Shutdown();
            Fiddler.FiddlerApplication.Startup(listenport_, Fiddler.FiddlerCoreStartupFlags.ChainToUpstreamGateway);
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["listenPort"].Value = listenport_.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            log2Box?.Invoke("监听端口更改为:" + listenport);
        }

        public void upstreamportchange(int upstreamport_)
        {
            upstreamport = upstreamport_.ToString();
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["upstreamPort"].Value = upstreamport_.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            log2Box?.Invoke("上流端口更改为:" + upstreamport);
        }

    }
}
