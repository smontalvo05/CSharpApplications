using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stevemontalvo_CE04
{
    class LogToConsole : Logger
    {
       

        public override void Log(string Log)
        {
            string log = Log;
                Console.WriteLine($"The line number is {Logger.LineNumber++} and the {log}");
        }

        public override void LogD(string LogD)
        {
            string log = LogD;
            Console.WriteLine($"The line number is {Logger.LineNumber++} and DEBUG the {log}");
        }

        public override void LogW(string LogW)
        {
            string log = LogW;
            Console.WriteLine($"The line number is {Logger.LineNumber++} and WARNING the {log}"); 
         }
       }
    }

