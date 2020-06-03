using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE07
{
    class Manager:Salaried
    {
        //bonus of type decimal - managers are salaried but usually receive a yearly bonus in addition to their normal pay.

        decimal _bonus;

        public Manager(string Name, string Address,decimal Salary, decimal Bonus) : base(Name, Address, Salary)
        {
            _bonus = Bonus;
        }

        public decimal Bonus
        {
            get
            {
                return _bonus;
            }

            set
            {
                _bonus = value;
            }
        }
        public override string ToString()
        {
            return "\n Employee Name: " + Name + " Employee Address: " + Address + " Employee Yearly Pay: " + CalculatePay() +"\n";
        }
        public override decimal CalculatePay()
        {
            
            return Salary + _bonus;
        }
        public static Manager AddManager()
        {
            Manager AddManager = null;

            Console.WriteLine("What is employee name?");
            string employeeName = Console.ReadLine();
            employeeName = UserValidation.IsNullOrWhiteSpace(employeeName);
            Console.WriteLine("What is the employee address?");
            string employeeAddress = Console.ReadLine();
            employeeAddress = UserValidation.IsNullOrWhiteSpace(employeeAddress);
            Console.WriteLine("What is the annual salary?");
            decimal employeePay = UserValidation.GetDecimal();
            Console.WriteLine("What is the annual bonus?");
            decimal employeeBonus = UserValidation.GetDecimal();
            AddManager = new Manager(employeeName, employeeAddress, employeePay,employeeBonus);

            return AddManager;
        }
    }
}
