using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ServerLibs.Logs
{
    public static class ServerLogs
    {
        static string logname = "serverlogs.txt";
        static FileStream stream;
        public static void WriteToLog(string log)
        {
            byte[] logBytes = Encoding.UTF8.GetBytes(log);
            try
            {
                using (stream = new FileStream($@"../{logname}", FileMode.OpenOrCreate))
                {
                    stream.BeginWrite(logBytes, 0, logBytes.Length, WriteToLogCallBack, null);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void WriteToLogCallBack(IAsyncResult ar)
        {
            stream.EndWrite(ar);
        }

        public static void CreateNewLog()
        {
            if (File.Exists($@"../{logname}")){
                File.Delete($@"../{logname}"); 
            }
            File.Create($@"../{logname}");
        }
    }
}
