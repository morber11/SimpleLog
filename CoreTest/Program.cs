using System;
using SimpleLog;

namespace CoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Log("test1");
            Logger.Log("test2");
            Logger.DeleteLastLog();
            Logger.SetLogFileName("testlog.log");
            Logger.WriteToFile();
        }
    }
}
