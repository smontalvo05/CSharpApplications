using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CEO2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu
            Console.Write("1. Create Customer \n");
            Console.Write("2. Create Account \n");
            Console.Write("3. Set Account Balance \n");
            Console.Write("4. Display Account Balance \n");
            Console.Write("5. Exit \n");

            //Validate the answer the candidate has chosen.
            int usersInput = Validate.ValidateUsersInput(1, 5);

            while (usersInput != 1)
            {
                Console.WriteLine("Please Create a Customer first");
                usersInput = Validate.ValidateUsersInput(1, 5);
            }

            //Utitlize the method to make sure that the user uses number one first. 
            string CustomersName = Customer.CustomerName(usersInput);

            //Checking if it worked
            Customer customerName = new Customer(CustomersName);

            //Getting info from user

            int userAccount = Validate.GetInt();

            decimal userBalance = Validate.GetDecimal();

            CheckingAccount accountBalance = new CheckingAccount(userAccount, userBalance);

            Console.WriteLine($"Your name is {customerName.GetName()} and your Account Number is {accountBalance.GetAccountNumber()} and you have this much in your account {accountBalance.GetAccountBalance()}");

            bool exit = Validate.GetBool();
        }
    }
}
