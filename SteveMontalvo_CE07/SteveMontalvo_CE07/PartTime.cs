using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE07
{
    class PartTime:Hourly
    {
        public PartTime (string Name, string Address, decimal PayPerHour, decimal HoursPerWeek):base(Name, Address, PayPerHour, HoursPerWeek)
        {
            
        }
        public override string ToString()
        {
            return "\n Employee Name: " + Name + " Employee Address: " + Address + " Employee Yearly Pay: " + CalculatePay() + "\n";
        }
        public override decimal CalculatePay()
        {
            return ((PayPerHour * HoursPerWeek)*52);//Multiplied hours plus hours per week times 52 weeks to get annual.

        }
        public static PartTime AddPTEmployee()
        {
            PartTime AddPartTime = null;

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
                AddPartTime = new PartTime(employeeName, employeeAddress, employeePay,hoursPerWeek);

            return AddPartTime;
        }
    }
}
