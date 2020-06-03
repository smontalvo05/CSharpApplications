using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stevemontalvo_CE04
{
    class Program
    {
        private static Logger _logger = null;

        static void Main(string[] args)
        {
            //Car Variable instantiate the variable
            Car currentCar=null;
            //Bool variable to keep program running.
            bool ProgramIsRunning = true;
           
            //loop to keep menu options running until user chooses to exit the program.
            while (ProgramIsRunning)
            {
                //Console Clear to clear out anything typed before this option
                Console.Clear();
                //Menu
                Console.WriteLine("1. Disable Logging");
                Console.WriteLine("2. Enable Logging");
                Console.WriteLine("3. Create A Car");
                Console.WriteLine("4. Drive the Car");
                Console.WriteLine("5. Destroy the Car");
                Console.WriteLine("6. Exit");
                //userInput and validate response is between 1 and 6
               string userInput = ValidateUserInput.MenuOptionValidation();

                //Cases to run the option that the users chooses.
                switch (userInput)
                {
                    case "1.":
                    case "1":
                    case "disable logging":
                        {
                            Console.WriteLine("You have now disabled logging.");
                            Utility.PauseBeforeContinuing();
                            //Created new DoNotLog object and stored it in Program Static Logger Field
                            _logger = new DoNotLog();
                            break;
                        }
                    case "2":
                    case "2.":
                    case "enable logging":
                        {
                            Console.WriteLine("You have now enable Logging.");
                            Utility.PauseBeforeContinuing();
                            //Created new LogToConsole object and stored it in Program Static Logger Field
                            _logger = new LogToConsole();
                            break;
                        }
                    case "3":
                    case "3.":
                    case "create a car":
                        {
                            
                            Console.Clear();
                            if (_logger == null)
                            {
                                Console.WriteLine("Make sure you enable or disable logging before you create a car.");
                                Utility.PauseBeforeContinuing();
                                break;
                            }
                            
                            //Creating the Car withinfo
                            Console.WriteLine("What is the color of your car?");
                            string color = Console.ReadLine();
                            color=ValidateUserInput.IsNullOrWhiteSpace(color);
                            Console.WriteLine("What is the make of your car?");
                            string make = Console.ReadLine();
                            make = ValidateUserInput.IsNullOrWhiteSpace(make);
                            Console.WriteLine("What is the model of your car?");
                            string model = Console.ReadLine();
                            model = ValidateUserInput.IsNullOrWhiteSpace(model);
                            float carMileage = ValidateUserInput.MileageOfCar();
                            int carYear = ValidateUserInput.yearOfCar();
                            //instantiated Car and pass through the users input
                            currentCar = new Car(make, model, color, carMileage, carYear);
                            // pause so that the user can see the response from creating the car
                            Utility.PauseBeforeContinuing();
                            break;
                        }
                    case "4":
                    case "4.":
                    case "drive the car":
                        {
                            if (currentCar == null)
                            {
                                Console.WriteLine("You need to create a car first!");
                                Utility.PauseBeforeContinuing();
                                break;
                            }
                            Console.WriteLine("How far are you driving the car?");
                            float carMileage = ValidateUserInput.MileageOfCar();
                            
                            currentCar.Drive(carMileage);
                            Utility.PauseBeforeContinuing();

                            break;
                        }
                    case "5":
                    case "5.":
                    case "destroy the car":
                        {
                            //set current car to null and erase the car you built
                            currentCar = null;
                            Console.WriteLine("You have now destroyed the car.");
                            Utility.PauseBeforeContinuing();
                            break;
                        }
                    case "6":
                    case "6.":
                    case "exit":
                        {
                            //Inform the user they are exiting the program
                            Console.WriteLine("You are now exiting the program.");
                            //Pause so they see the message
                            Utility.PauseBeforeContinuing();
                            //Boolean to false to stop the loop and program
                            ProgramIsRunning = false;
                            break;
                        }

                }


            }

            
                        
        }
        //Method to retrieve the Logger Class
        public static Logger GetLogger()
        {

            return _logger;

        }
        
    }
}
