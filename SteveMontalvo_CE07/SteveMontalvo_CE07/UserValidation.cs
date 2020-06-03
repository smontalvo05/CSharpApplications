using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE07
{
    class UserValidation
    {
        //Validate decimal
        public static decimal GetDecimal(string message = "Please enter a valid number: ")
        {
            decimal validatedDecimal;
            string input = null;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();

            } while (!decimal.TryParse(input, out validatedDecimal));

            return validatedDecimal;

        }
        //validate int
        public static int GetInt(string message = "Please enter a valid number: ")
        {
            int validatedInt;
            string input = null;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();

            } while (!int.TryParse(input, out validatedInt));

            return validatedInt;

        }//validate its not null or whitespace.
        public static string IsNullOrWhiteSpace(string usersName)
        {
            while (string.IsNullOrWhiteSpace(usersName))
            {
                Console.WriteLine("Please enter a valid response: ");
                usersName = Console.ReadLine();
            }
            return usersName;
        }
    }
}
