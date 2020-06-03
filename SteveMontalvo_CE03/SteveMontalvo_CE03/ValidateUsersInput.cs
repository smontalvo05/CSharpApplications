using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE03
{
    class ValidateUsersInput
    {
        public static int Age (string message = "Please enter only a Number for your age:")
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
        public static int SizeOfClass (string message = "Please enter only a Number for the size of your class:")
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
        public static int Grade (string message = "Please enter only a Number for your grade:")
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
        public static int MenuOptionValidation (int min, int max, string message = "Please enter a Menu Option: ")
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
                Console.WriteLine("Please select one of the menu options: ");
                usersName = Console.ReadLine();
            }
            return usersName;
        }

    }
 }

