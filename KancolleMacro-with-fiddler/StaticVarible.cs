namespace KancolleMacro_with_fiddler
{
    public class convarible
    {
        //Fiddler端口设置
        //public static int listen_port;
        //public static int upstream_port;
        //Json数据
        public static int port_api_result;
        public static int charge_api_result;
        public static int mission_api_result;
        public static int result_api_result;
        public static int ExStart_api_result;
        //舰队设置
        public static int[] Team_index;
        public static bool[] Team_GO;
        //时间设置
        public static int RndTimeRange;
        public static int RndWaitTimeRange;
        public static int RndPixelRange;
        public static int Overtime;
        public static int[] Expeditiontime;
        public static long[] api_mission_time;
        //线程标志符
        public static bool[] Threadflag;
        //其他设置
        //public static bool NeedSupply;//设置补给flag
        public static int DPIscale;
        //poiY轴修正
        public static int poiXcorrect = 0;
        public static int poiYcorrect = 0;

        public static void inital()
        {
            Expeditiontime = new int[41]{
                                        0,15,30,20,50,60+30,40,60,3*60,
                                        4*60,60+30,5*60,8*60,4*60,6*60,12*60,15*60,
                                        45,5*60,6*60,2*60,2*60+20,3*60,4*60,8*60+20,
                                        40*60,80*60,20*60,25*60,24*60,48*60,2*60,24*60,
                                        15,30,7*60,9*60,2*60+45,2*60+55,30*60,6*30+50
                                        };
            Team_index = new int[3];
            Team_GO = new bool[3];
            Threadflag = new bool[3]{false,false,false };
            port_api_result = -1;
            mission_api_result = -1;
            charge_api_result = -1;
            ExStart_api_result = -1;
            api_mission_time = new long[4] { 0, 0, 0, 0 };

        }

        public static void rndTimeModification()
        {
            if (RndTimeRange>100)
            {
                RndTimeRange = 100;
            }
        }

        public static void rndPixelModification()
        {
            if (RndPixelRange > 10)
            {
                RndPixelRange = 10;
            }
        }
    
    }
}
