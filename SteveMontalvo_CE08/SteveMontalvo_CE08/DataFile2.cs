using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE08
{
    class DataFile2
    {
        string[] dataInfo = File.ReadAllLines(@"..\..\DataFile2.txt");
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
