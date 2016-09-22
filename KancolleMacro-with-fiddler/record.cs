using System;
using System.IO;

namespace KancolleMacro_with_fiddler
{
    class record
    {

    }

    //系统记录日志系统
    //需要在main函数中调用
    //Trace.Listeners.Clear();  //清除系统监听器 (就是输出到Console的那个)
    //Trace.Listeners.Add(new MyTraceListener()); //添加MyTraceListener实例
    //
    //class MyTraceListener : TraceListener
    //{       
    //    public override void Write(string message)
    //    {
    //        File.AppendAllText(dir + "Log.txt", message);
    //    }

    //    public override void WriteLine(string message)
    //    {
    //        File.AppendAllText(dir + "Log.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss    ") + message + Environment.NewLine);
    //    }
    //}
}
