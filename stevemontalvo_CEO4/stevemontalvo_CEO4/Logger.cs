using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stevemontalvo_CEO4
{
    abstract class Logger:ILog
    {
        private int _lineNumber;
        public void Log(string Log)
        {

        }

        public void LogD(string LogD)
        {

        }

        public void LogW(string LogW)
        {

        }
        

        public int lineNumbers
        {
            get
            {
                return _lineNumber;

            }

            set
            {
                _lineNumber = value;

            }
        }
        public Logger (int lineNumber)
        {

            _lineNumber = lineNumber;

        }

        public static int lineNumber()
        {



        }


      
    }
}
