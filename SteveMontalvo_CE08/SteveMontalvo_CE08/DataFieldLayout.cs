using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE08
{
    class DataFieldLayout
    {
        string[] lines = File.ReadAllLines(@"..\..\DataFieldsLayout.txt");

        public string[] Lines
        {
            get
            {
                return lines;
            }

            set
            {
               lines = value;
            }
        }

    }
}
