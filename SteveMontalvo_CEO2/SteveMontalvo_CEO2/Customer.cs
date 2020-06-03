using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CEO2
{
    class Customer
    {
        int _checkingAccount = 0123456;
        string _name;

        public string GetName()
        {

            return _name;

        }

        public void SetName(string Name)
        {


            _name = Name;

        }
        public static string CustomerName(int usersInput)
        {
            string usersName = null;
            switch (usersInput)
            {
                case 1:
                    Console.WriteLine("Please Enter your name: ");
                    usersName = Console.ReadLine();
                    usersName = Validate.IsNullOrWhiteSpace(usersName);
                    return usersName;

                case 2:

                    Console.WriteLine("Please Make sure that you creat your username first: ");
                    usersName = Console.ReadLine();

                    break;
                case 3:

                    Console.WriteLine("Please Make sure that you creat your username first: ");
                    usersName = Console.ReadLine();

                    break;
                case 4:

                    Console.WriteLine("Please Make sure that you creat your username first: ");
                    usersName = Console.ReadLine();

                    break;
                case 5:

                    Console.WriteLine("Please Make sure that you creat your username first: ");
                    usersName = Console.ReadLine();

                    break;
            }

            return usersName;

        }

        public Customer(string Name)
        {

            _name = Name;

        }
    }
}
