using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stevemontalvo_CE06
{
    class Validation
    {
        public static int GetInt(String message = "Enter an Integer: ")
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
        public static int GetInt(int min, int max, string message = "Enter an integer: ")
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
        public static double GetDouble(string message = "Enter a Number: ")
        {
            double validatedDouble;
            string input = null;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();

            } while (!Double.TryParse(input, out validatedDouble));

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
    }
}
