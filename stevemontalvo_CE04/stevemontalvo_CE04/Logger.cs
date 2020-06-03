using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stevemontalvo_CE04
{
    abstract class Logger : ILog
    {
        private static int _lineNumber=1;

        abstract public void Log(string Log);

        abstract public void LogD(string LogD);

        abstract public void LogW(string LogW);

        protected static int LineNumber
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


        
            
        
        
    }
}
