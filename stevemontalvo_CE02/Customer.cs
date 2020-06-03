using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stevemontalvo_CE02
{
    class Customer
    {
        int _checkingAccount;
        string _name;

        public int GetCheckingAccount()
        {

            return _checkingAccount;
        }

        public void SetCheckingAccount (int checkingAccount)
        {

            _checkingAccount = checkingAccount;
        }

        public string GetName()
        {

            return _name;
        }

        public void SetName(string name)
        {

            _name = name;
        }

        public Customer (int checkingAccount, string name)
        {
            _checkingAccount = checkingAccount;
            _name = name;

        }
    }
}
