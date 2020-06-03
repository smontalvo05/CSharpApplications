using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE03
{
    class Course
    {
        string _courseTitle;
        string _courseDescription;
        Student[] _students;
        Teacher _teach;

        public Course(string CourseTitle, string CourseDescription, int SizeOfStudents)
        {
            int sizeOfStudent=SizeOfStudents;

            _courseDescription = CourseDescription;
            _courseTitle = CourseTitle;
            _students = new Student [sizeOfStudent];

        }

        public string CourseTitle
        {
            get { return _courseTitle; }
            set { _courseTitle = value; }

        }

        public string CourseDescription
        {
            get { return _courseDescription; }
            set { _courseDescription = value; }
        }


        public Teacher Teach
        {
            get
            {
                return _teach;
            }

            set
            {
                _teach = value;
            }
        }

        public Student[] StudentArray
        {
            get
            {
                return _students;
            }

            set
            {
                _students = value;
            }
        }
    }
}
