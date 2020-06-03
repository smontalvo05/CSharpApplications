using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE07
{
    class Contractor:Hourly
    {
        //noBenefitsBonus of type decimal - contractors tend to be paid 10 to 15 % more than normal employees because they do not receive benefits.
        decimal _noBenefitsBounus;

        public Contractor (string Name, string Address, decimal NoBenefitsBonus, decimal PayPerHour, decimal HoursPerWeek) : base(Name, Address, PayPerHour,HoursPerWeek)
            {
            _noBenefitsBounus = NoBenefitsBonus;
            }
      public override decimal CalculatePay()
        {
           return ((PayPerHour + (PayPerHour * _noBenefitsBounus))*52);
            
        }
        public decimal NoBenefitsBounus
        {
            get
            {
                return _noBenefitsBounus;
            }

            set
            {
                _noBenefitsBounus = value;
            }
        }
        public override string ToString()
        {
            return "\n Employee Name: " + Name + " Employee Address: " + Address + " Employee Yearly Pay: " + CalculatePay() + "\n";
        }
        public static Contractor AddContractorEmployee()
        {
            Contractor AddContractor = null;

            Console.WriteLine("What is your name?");
            string employeeName = Console.ReadLine();
            employeeName = UserValidation.IsNullOrWhiteSpace(employeeName);
            Console.WriteLine("What is your address?");
            string employeeAddress = Console.ReadLine();
            employeeAddress = UserValidation.IsNullOrWhiteSpace(employeeAddress);
            Console.WriteLine("What is your current pay?");
            decimal employeePay = UserValidation.GetDecimal();
            Console.WriteLine("How many hours per week are you working?");
            decimal hoursPerWeek = UserValidation.GetDecimal();
            decimal noBenefitsBonus = 10;
            AddContractor = new Contractor(employeeName, employeeAddress,noBenefitsBonus, employeePay,hoursPerWeek);

            return AddContractor;
        }
    }
}
