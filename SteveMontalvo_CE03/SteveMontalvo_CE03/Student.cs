using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE03
{
    class Student:Person
    {
        int _grade;

        public int Grade
        {

            get { return _grade; }
            set { _grade = value; }

        }

       

        public Student (string Name, string PersonDescription, int Age, int Grade):base(Name,PersonDescription,Age)
        {

            _grade = Grade;

        }
    }
}
