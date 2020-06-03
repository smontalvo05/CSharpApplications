using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stevemontalvo_CE02
{
    class Program
    {
        static void Main(string[] args)
        {
            
        //ask the user for thier name
        Console.Write("Please enter your name: \nYour Name is:  ");
            string customerName = Console.ReadLine();

        //validate the user didnt leave a null or white space
            string usersName = ValidResponse(customerName);

            Console.Write($"{usersName} Please enter your account number and press enter to continue.\nYour Response: ");

            //Capture users input
            string userAccountNumber = Console.ReadLine();
            //Validate the user didnt leave a null or white space
            string usersAccountNumber = ValidResponse(userAccountNumber);

            int usersAccountNumbers;
            while (!(int.TryParse(usersAccountNumber, out usersAccountNumbers)))
            {
                Console.Write("Oops! this not a number" + "\n\r" + "Please enter a only numbers and Press Enter." + "\n\r" + "Your Response is: ");
                usersAccountNumber = Console.ReadLine();

            }
            Customer customerInfo; new Customer(usersAccountNumbers, usersName);

            customerInfo.SetName(usersName);
            customerInfo.SetCheckingAccount(usersAccountNumbers);


            Console.Write(customerInfo.GetName());

        }
        //Function to validate null or white spaces
        public static string ValidResponse (string customer)
        {
            //To check and make sure that there are no null or white spaces.
            while (string.IsNullOrWhiteSpace(customer))
            {

                //Telling the user to a response. Don't leave it in blank.
                Console.Write("Oops! Don't leave this in Blank!" + "\n\r" + "Please enter a phone number and Press Enter." + "\n\r" + "Your Response is: ");
                //Recapture response from the user.
                customer = Console.ReadLine();

            }
            //return the value as long as its not null or white space
            return customer;
        }
        
    }
}
