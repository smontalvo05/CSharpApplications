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
            // array for fish 
            string[] fishArray = {"Red","Blue","Yellow","Green", "Red", "Blue", "Yellow", "Green", "Red", "Blue", "Yellow", "Green" };
            //array for length
            float[] fishLength = {2.75f, 3.45f, 6.6f, 7.6f, 8.8f, 9.8f, 1.0f, 2.0f, 11.0f, 8.0f, 14.0f, 1.4f };

            //menu
            Console.WriteLine("Please select one of the following colors: ");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Yellow");
            Console.WriteLine("4. Green");
            Console.Write("Selection: ");

            // variable to enter users input
            string userInput = Console.ReadLine();

            //call method to validate number is between 1 and 4
           int number= Validate(userInput);
            
            //checking method worked.
            Console.WriteLine($"Your Response is {number}");

            if (number == 1)
            {



            }

        }
        
        public static int Validate(string userInput)
        {
            //local variable to send out
            int usersInput;
            //bool variable for validation
            bool validate = true;
            //validation of users input using the while loop
            while ( validate = (!(Int32.TryParse(userInput, out usersInput)&&(usersInput>=1 && usersInput<=4))))

            {
                // tell the user what they did wrong
                Console.WriteLine("Please only enter a number between 1-4: ");
                Console.Write("Your Response: ");
                //capture the response again to validate response.
                userInput = Console.ReadLine();
               
            }
            //send out the correct response back to the user
                return usersInput;
        }
    }
}
