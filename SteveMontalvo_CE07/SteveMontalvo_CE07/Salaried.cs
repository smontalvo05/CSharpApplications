using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE07
{
    class Salaried : Employee
    {
        //salary of type decimal - salaried employees get a lump sum each year no matter the number of hours worked.
        decimal _salary;
        //constructor.
        public Salaried (string Name, string Address, decimal Salary):base (Name, Address)
        {
            _salary = Salary;
        }

        //property to store salary.
        public decimal Salary
        {
            get
            {
                return _salary;
            }

            set
            {
                _salary = value;
            }
        }
        //method so override to see whats entered in the list.
        public override string ToString()
        {
            return "\n Employee Name: " + Name + " Employee Address: " + Address + " Employee Yearly Pay: " + Salary + "\n";
        }
        //Metho to add an employee to salary.
        public static Salaried AddSalariedEmployee()
        {
           Salaried AddSalaryEmployee = null;

            Console.WriteLine("What is your name?");
            string employeeName = Console.ReadLine();
            employeeName = UserValidation.IsNullOrWhiteSpace(employeeName);
            Console.WriteLine("What is your address?");
            string employeeAddress = Console.ReadLine();
            employeeAddress = UserValidation.IsNullOrWhiteSpace(employeeAddress);
            Console.WriteLine("What is the employee's salary?");
            decimal employeePay = UserValidation.GetDecimal();
            AddSalaryEmployee = new Salaried(employeeName, employeeAddress,employeePay);

            return AddSalaryEmployee;
        }
    }
}
