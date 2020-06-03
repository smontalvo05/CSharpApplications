using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex4
{
    class ColorFactsCollection
    {
        //to collect the colors and the information
        Dictionary<string, Color> colorFacts = new Dictionary<string, Color>();

        //property 
        public Dictionary<string, Color> ColorFacts
        {
            get
            {
                return colorFacts;
            }

            set
            {
                colorFacts = value;
            }
        }

    }
}
