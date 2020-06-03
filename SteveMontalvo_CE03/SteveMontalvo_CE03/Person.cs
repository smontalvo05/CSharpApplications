using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE03
{
    class Person
    {
        string _name;
        string _personDescription;
        int _age;

        public Person(string Name, string PersonDescription, int Age)
        {

            _age = Age;
            _personDescription = PersonDescription;
            _name = Name;

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PersonDescription
        {

            get { return _personDescription; }
            set { _personDescription = PersonDescription; }

        }

        public int Age
        {

            get { return _age; }
            set { _age = value; }

        }

        
    }
}
