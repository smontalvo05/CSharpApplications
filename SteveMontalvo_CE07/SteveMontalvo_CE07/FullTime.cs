using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE07
{
    class FullTime:Hourly
    {
        public FullTime(string Name, string Address, decimal PayPerHour, decimal HoursPerWeek=40) : base(Name, Address, PayPerHour,HoursPerWeek)
        {
            
        }
        public override string ToString()
        {
            return "\n Employee Name: " + Name + " Employee Address: " + Address + " Employee Yearly Pay: " +CalculatePay() + "\n";
        }
        public override decimal CalculatePay()
        {
            return PayPerHour * HoursPerWeek;

        }
        public static FullTime AddFTEmployee()
        {
            FullTime AddFullTime = null;

                Console.WriteLine("What is your name?");
                string employeeName = Console.ReadLine();
                employeeName = UserValidation.IsNullOrWhiteSpace(employeeName);
                Console.WriteLine("What is your address?");
                string employeeAddress = Console.ReadLine();
                employeeAddress = UserValidation.IsNullOrWhiteSpace(employeeAddress);
                Console.WriteLine("What is your current pay?");
                decimal employeePay = UserValidation.GetDecimal();
                AddFullTime = new FullTime(employeeName, employeeAddress, employeePay);

            return AddFullTime;
        }
    }
}
