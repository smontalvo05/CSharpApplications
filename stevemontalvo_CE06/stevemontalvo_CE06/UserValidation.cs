using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE06
{
    class UserValidation
    {
        public static decimal ValidDecimal(string message = "Please enter a valid number:")
        {

            decimal validateddecimal;
            string input = null;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();


            } while (!decimal.TryParse(input, out validateddecimal));

            return validateddecimal;


        }
        public static int IndexNumberCheck(string message = "Please enter only the index number that is next to the card you want to add to the collection: ")
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
        public static string MenuOptionValidation(string message = "Please enter a Menu Option: ")
        {
            string input;

            do
            {
                Console.Write(message);
                input = Console.ReadLine().ToLower();
            } while ((input != "1" && input != "1.") && (input != "2" && input != "2.") && (input != "3" && input != "3.") && (input != "4" && input != "4.") && (input != "5" && input != "5.") && (input != "6" && input != "6.") && (input != "disable logging" && input != "enable logging") && (input != "create a car" && input != "drive a car") && (input != "destroy the car" && input != "exit"));

            return input;

        }


        public static string IsNullOrWhiteSpace(string userInput)
        {
            while (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Please enter a valid response: ");
                userInput = Console.ReadLine();
            }
            return userInput;
        }
    }
}
