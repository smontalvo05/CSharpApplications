using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE03
{
    class Teacher : Person
    {

        string[] _knowledge;
       

        public string [] Knowledge
        {

            get { return _knowledge; }
            set { _knowledge = value; }
        }

       

        public Teacher (string Name, string PersonDescription, int Age, string[] Knowledge):base (Name, PersonDescription, Age)
        {
            _knowledge = Knowledge;

        }
        
    }
}
