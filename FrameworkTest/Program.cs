using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLog;

namespace FrameworkTest
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
