using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();

            //Bool to keep the program running
            bool ProgramIsRunning = true;

            while (ProgramIsRunning)
            {
                //Menu
                Console.WriteLine("List of Employee");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Display Payroll");
                Console.WriteLine("4. Exit");
                string userInput = Console.ReadLine();
                userInput = UserValidation.IsNullOrWhiteSpace(userInput.ToLower());

                //utilize swith to valid the users response.
                switch (userInput)
                {
                    case "1":
                    case "1.":
                    case "add employee":
                        {
                            //Add employee - lets the user to choose to create an employee of type 
                            //(FullTime, PartTime, Contractor, Salaried, or Manager) prompts the user for the appropriate values, 
                            //and adds them to the list. 
                            Console.WriteLine("Please choose one of the following options to add an Employee: ");
                            Console.WriteLine("1. Full Time");
                            Console.WriteLine("2. Part Time");
                            Console.WriteLine("3. Contractor");
                            Console.WriteLine("4. Salaried");
                            Console.WriteLine("5. Manager");
                            string addEmployee = Console.ReadLine();
                            addEmployee = UserValidation.IsNullOrWhiteSpace(addEmployee);
                        }
                        break;
                    case "2":
                    case "2.":
                    case "remove employee":
                        {

                        }
                        break;
                    case "3":
                    case "3.":
                    case "display payroll":
                        {

                        }
                        break;
                    case "4":
                    case "4.":
                    case "exit":
                        {
                            Console.WriteLine("You have chosen to exit you are now exiting the program.");
                            ProgramIsRunning = false;
                            Utility.PauseBeforeContinuing();

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("You have not chosen a valid response.");
                            Utility.PauseBeforeContinuing();
                        }
                        break;

                }


            }
        }
    }
}
