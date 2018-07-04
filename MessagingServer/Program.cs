using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingServer
{
    class Program
    {
        private static bool isGUI = false;
        private static int ServerPortNumber;

        static void Main(string[] args)
        {
            ParseArguments(args);
        }

        static void ParseArguments(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i]) {
                    case "-p":
                        Int32.TryParse(args[i + 1], out ServerPortNumber);
                        break;
                    case "/showgui":
                        isGUI = true;
                        break;
                }
            }
        }
    }
}
