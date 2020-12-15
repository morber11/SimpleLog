using System;
using System.Collections.Generic;
using System.IO;

namespace SimpleLog
{
    public class Logger
    {
        private static readonly Logger instance = new Logger();
        private readonly List<string> _log;
        private string _filename;

        private Logger()
        {
            _log = new List<string>();
            _filename = "logfile.log";
        }

        public static List<string> GetLog()
        {
            return instance._log;
        }

        public static string GetLogFileName()
        {
            return instance._filename;
        }

        public static void SetLogFileName(string name)
        {
            instance._filename = name;
        }

        public static void WriteToFile()
        {
            string outputPath = @".\" + instance._filename;

            try
            {
                if (File.Exists(outputPath))
                    File.Delete(outputPath);

                File.WriteAllLines(outputPath, instance._log);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex);
                Log(ex.Message);
            }
        }

        public static void WriteToFile(string path)
        {
            string outputPath = path + instance._filename;

            try
            {
                if (File.Exists(outputPath))
                    File.Delete(outputPath);

                File.WriteAllLines(outputPath, instance._log);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex);
                Log(ex.Message);
            }
        }

        public static void Log(string text)
        {
            string error = "NEW ENTRY LOGGED: " +
                DateTime.Now +
                Environment.NewLine +
                "------------------------------------------------------------" +
                Environment.NewLine +
                text +
                Environment.NewLine
                ;

            instance._log.Add(error);
        }

        public static void FlushLog()
        {
            instance._log.Clear();
        }

        public static void DeleteLastLog()
        {
            instance._log.RemoveAt(instance._log.Count - 1);
        }
    }
}
