using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex4
{
    class Color
    {
        //variables
        string _colorName;
        string[] _colorFacts =new string [3];

        //constructor
        public Color(string ColorName)
        {
            _colorName = ColorName;

        }
        //property
        public string ColorName
        {
            set
            {

                _colorName = value;

            }

            get
            {

                return _colorName;

            }

        }
        //property 
        public string [] ColorFacts
        {

            set
            {

                _colorFacts = value;

            }

            get
            {

                return _colorFacts;
            }


        }
        
    }
}
