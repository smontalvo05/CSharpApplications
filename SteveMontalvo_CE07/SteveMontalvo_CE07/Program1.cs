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
                Console.Clear();
                //Menu

                Console.WriteLine("---------------------Menu--------------------- \n ");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Display Payroll");
                Console.WriteLine("4. Exit");
                Console.Write("\n Please select one of the following options from the menu above: ");
                string userInput = Console.ReadLine();
                userInput = UserValidation.IsNullOrWhiteSpace(userInput.ToLower());

                //utilize swith to valid the users response.
                switch (userInput)
                {
                    case "1":
                    case "1.":
                    case "add employee":
                        {
                            Console.Clear();
                            //Add employee - lets the user to choose to create an employee of type 
                            //(FullTime, PartTime, Contractor, Salaried, or Manager) prompts the user for the appropriate values, 
                            //and adds them to the list.
                            Console.WriteLine("---------Menu--------- \n");
                            
                            Console.WriteLine("1. Full Time");
                            Console.WriteLine("2. Part Time");
                            Console.WriteLine("3. Contractor");
                            Console.WriteLine("4. Salaried");
                            Console.WriteLine("5. Manager \n");
                            Console.Write("Please choose one of the following options to add an Employee: ");
                            string addEmployee = Console.ReadLine();
                            addEmployee = UserValidation.IsNullOrWhiteSpace(addEmployee.ToLower());
                            if ((addEmployee == "full time"|| addEmployee == "1")||(addEmployee == "1."||addEmployee=="fulltime"))
                            {
                                Console.Clear();
                                EmployeeList.Add(FullTime.AddFTEmployee());
                            }
                            if ((addEmployee == "part time" || addEmployee == "2") || (addEmployee == "2." || addEmployee == "parttime"))
                            {
                                Console.Clear();
                                EmployeeList.Add(PartTime.AddPTEmployee());
                            }
                            if ((addEmployee == "contractor" || addEmployee == "3") || addEmployee == "3.")
                            {
                                Console.Clear();
                                EmployeeList.Add(Contractor.AddContractorEmployee());
                            }
                            if ((addEmployee == "salaried" || addEmployee == "4") || addEmployee == "4.")
                            {
                                Console.Clear();
                                EmployeeList.Add(Salaried.AddSalariedEmployee());
                            }
                            if ((addEmployee == "manager" || addEmployee == "5") || addEmployee == "5.")
                            {
                                Console.Clear();
                                EmployeeList.Add(Manager.AddManager());
                            }
                            else
                            {
                                Console.WriteLine("You did not enter a valid response. Please enter one of the menu options above.");
                                Utility.PauseBeforeContinuing();
                            }

                        }
                        break;
                    case "2":
                    case "2.":
                    case "remove employee":
                        {
                            Console.Clear();
                            DisplayList(EmployeeList);
                            Console.WriteLine("Please select the number next to the Employees that you wish to remove:");
                            RemoveEmployee(EmployeeList);
                            Utility.PauseBeforeContinuing();
                        }
                        break;
                    case "3":
                    case "3.":
                    case "display payroll":
                        {
                            Console.Clear();
                            DisplayPayroll(EmployeeList);
                            Utility.PauseBeforeContinuing();
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
        public static void DisplayList<t>(List<t> _list)
        {
            if (_list.Count > 0)
            {
                Console.WriteLine("\n Employee Index Number and Values: \n-----------------------------");
                int i = 0;
                foreach (t key in _list)
                {
                    Console.WriteLine("Index [" + i + "] Value: " + key);
                    ++i;
                }
            }
            else
            {
                Console.WriteLine("No values to print!");
            }
            Console.Write("\n");
        }
        public static void RemoveEmployee <t>(List<t> Employee)
        {
            // Validate that the user uses a number for the index
            int i = UserValidation.GetInt();
            //check if the user entered a number within the index to remove
            if (i >= 0 && i < Employee.Count)
            {
                Employee.RemoveAt(i);
            }
            else
            {
                Console.WriteLine("The number you have chosen " + i + " is not within the numbers that are in the list. You must choose a number that is within index numbers that are shown.");

            }

        }
        public static void DisplayPayroll <t>(List<t> _list)
        {
            if (_list.Count > 0)
            {
                Console.WriteLine("\n Employee List: \n-----------------------------");
                int i = 0;
                foreach (t key in _list)
                {
                    Console.WriteLine(key);
                    ++i;
                }
            }
            else
            {
                Console.WriteLine("No values to print!");
            }
            Console.Write("\n");
        }
    }
}
