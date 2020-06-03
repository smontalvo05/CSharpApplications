using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex3
{
    class Courses
    {
        //variable to hold the array.
        string[] _courseNames = { "History of Soccer", "History of Baseball","History of Tennis","Calculas of Baseball","History of Basketball" };

        //property to display the array
        public string [] CourseNames
        {
            get
            {
                return _courseNames;
            }

        }
    }
}
