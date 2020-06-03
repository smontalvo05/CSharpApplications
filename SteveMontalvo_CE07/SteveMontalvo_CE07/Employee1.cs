using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE07
{
    class Employee:IComparable
    {
        string _name;
        string _address;

        public Employee (string Name, string Address)
        {
            _name = Name;
            _address = Address;

        }

  
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public int CompareTo(object obj)
        {
            return _name.CompareTo(obj);
        }

        public virtual decimal CalculatePay()
        {
            decimal Pay=0;

            return Pay;

        }
    }
}
