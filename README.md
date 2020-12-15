# SimpleLog
---------------------

Simple Logging Application for .NET projects.

Add a reference to SimpleLog and use like so:

            Logger.Log("test1");
            Logger.WriteToFile();
            
Alternatively you can specify a filename for the Log file. The Default is "logfile.log"

            Logger.SetLogFileName("mylogfile.txt");
            
You can also specify the path for logging using the following syntax:

            Logger.SetLogPath("C:\logdump");
            
The log can be completely cleared using the following syntax:

            Logger.Flush();
            
# Use case
---------------------
Here is an example use case for this class library.

            try
            {
                SomeOperation();
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }
            
