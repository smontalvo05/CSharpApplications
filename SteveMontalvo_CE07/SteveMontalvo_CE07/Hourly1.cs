using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE07
{
    class Hourly : Employee
    {
        decimal _payPerHour;
        decimal _hoursPerWeek;

        public Hourly (string Name, string Address, decimal PayPerHour, decimal HoursPerWeek):base(Name, Address)
        {
            _payPerHour = PayPerHour;
            _hoursPerWeek = HoursPerWeek;

        }

        public decimal PayPerHour
        {
            get
            {
                return _payPerHour;
            }

            set
            {
                _payPerHour = value;
            }
        }

        public decimal HoursPerWeek
        {
            get
            {
                return _hoursPerWeek;
            }

            set
            {
                _hoursPerWeek = value;
            }

        }

    }
}
