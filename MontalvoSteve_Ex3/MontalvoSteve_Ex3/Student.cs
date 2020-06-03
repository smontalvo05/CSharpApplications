using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex3
{
    class Student
    {
        //Variables to hold info
        string [] _studentName = { "Steve Montalvo", "Whitney Core", "Idalys Montalvo", "Allie Core", "Michael Griffin" };
        double[] _allieGrades = {89,78,67,88,90 };
        double[] _michaelGrades= {100,67,72,47,89 };
        double[] _steveGrades= {72,100,88,98,67 };
        double[] _idalysGrades= {55,78,99,100,76 };
        double[] _whitneyGrades= {100,98,89,88,100 };

        //Properties to retrieve and set the info.
        public string[] StudentName
        {
            get
            {
                return _studentName;
            }

        }

        public double[] AllieGrades
        {
            get
            {
                return _allieGrades;
            }

            set
            {
                _allieGrades = value;
            }
        }

        public double[] MichaelGrades
        {
            get
            {
                return _michaelGrades;
            }

            set
            {
                _michaelGrades = value;
            }
        }

        public double[] SteveGrades
        {
            get
            {
                return _steveGrades;
            }

            set
            {
                _steveGrades = value;
            }
        }

        public double[] IdalysGrades
        {
            get
            {
                return _idalysGrades;
            }

            set
            {
                _idalysGrades = value;
            }
        }

        public double[] WhitneyGrades
        {
            get
            {
                return _whitneyGrades;
            }

            set
            {
                _whitneyGrades = value;
            }
        }
    }
}
