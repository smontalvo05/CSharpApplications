using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE08
{
    class DataFile1
    {
     string[] dataInfo = File.ReadAllLines(@"..\..\DataFile1.txt");
        
        public string[] DataInfo
        {
            get
            {

                return dataInfo;
            }

         set
            {
                dataInfo = value;
            }
        }
        
    }
   
}
