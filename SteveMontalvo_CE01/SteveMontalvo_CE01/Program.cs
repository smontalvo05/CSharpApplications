using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE01
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fishArray = {"Red","Blue","Yellow","Green", "Red", "Blue", "Yellow", "Green", "Red", "Blue", "Yellow", "Green" };
            float[] fishLength = {2.75f, 3.45f, 6.6f, 7.6f, 8.8f, 9.8f, 1.0f, 2.0f, 11.0f, 8.0f, 14.0f, 1.4f };


            Console.WriteLine("Please select one of the following colors: ");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Yellow");
            Console.WriteLine("4. Green");
            Console.Write("Selection: ");
            string userInput = Console.ReadLine();

           int number= Validate(userInput);

            Console.WriteLine($"Your Response is {number}");
            
         

        }
        public static int Validate(string userInput)
        {

            int usersInput;
            userInput = null;
            bool validate = Int32.TryParse(userInput, out usersInput);
            while (validate == false)
            {
                Console.WriteLine("Please only enter a number between 1-4: ");
                Console.Write("Your Response: ");
                userInput = Console.ReadLine();
            }
            
            
            return usersInput;
        }
    }
}
