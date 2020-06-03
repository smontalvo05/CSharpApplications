using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CEO2
{
    class Validate
    {
        public static int GetInt(string message = "Please enter your Account Number:")
        {

            int validatedInt;
            string input = null;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();


            } while (!Int32.TryParse(input, out validatedInt));

            return validatedInt;


        }
        public static int ValidateUsersInput(int min, int max, string message = "Please enter a number between 1-5: ")
        {
            int validatedInt;
            string input = null;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!(Int32.TryParse(input, out validatedInt) && (validatedInt >= min && validatedInt <= max)));

            return validatedInt;

        }

        public static bool GetBool(string message = "Please type Exit to Exit out of the program: ")
        {

            bool selectedOption = true;

            bool stillLookingForAValidResponse = true;
            string input = null;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();

                switch (input.ToLower())
                {

                    case "Exit":
                    case "exit":
                    case "EXiT":
                    case "EXIT":

                        {
                            selectedOption = true;
                            stillLookingForAValidResponse = false;

                        }
                        break;

                }
            } while (stillLookingForAValidResponse);
            return selectedOption;

        }
        public static decimal GetDecimal(string message = "Enter a Your Account Balance: ")
        {
            decimal validatedDouble;
            string input = null;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();

            } while (!decimal.TryParse(input, out validatedDouble));

            return validatedDouble;

        }

        public static double GetDouble(double min, double max, string message = "Entere a Number: ")
        {
            double validatedDouble;
            string input = null;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!(double.TryParse(input, out validatedDouble) && (validatedDouble >= min && validatedDouble <= max)));

            return validatedDouble;
        }
        public static string IsNullOrWhiteSpace(string usersName)
        {
            while (string.IsNullOrWhiteSpace(usersName))
            {
                Console.WriteLine("Please enter your name: ");
                usersName = Console.ReadLine();
            }
            return usersName;
        }
    }
}
