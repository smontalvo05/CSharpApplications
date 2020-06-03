using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE08
{
    class ValidateUserResponse
    {
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
