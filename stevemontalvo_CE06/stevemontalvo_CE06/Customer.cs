using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stevemontalvo_CE06
{
    class Customer
    {
        static int _checkingAccount = 01010220;
        
        string _customerName;
      
        public string GetCustomerName()
        {

            return _customerName;

        }

        public void SetCustomerName(string CustomerName)
        {

            _customerName = CustomerName;

        }
       

        public Customer (string CustomerName)
            {
            _customerName = CustomerName;


        }
        
        public static string CustomerName (int usersInput)
        {
            string usersName = null;
            switch (usersInput)
            {
                case 1:
                    Console.WriteLine("Please Enter your name: ");
                    usersName = Console.ReadLine();
                    usersName = Validation.IsNullOrWhiteSpace(usersName);
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
}
}
