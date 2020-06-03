using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CEO2
{
    class CheckingAccount
    {
        decimal _accountBalance;
        int _accountNumber;

        public decimal GetAccountBalance()
        {

            return _accountBalance;

        }

        public void SetAccountBalance(decimal AccountBalance)
        {

            _accountBalance = AccountBalance;

        }

        public int GetAccountNumber()
        {

            return _accountNumber;

        }

        public void SetAccountNumber (int AccountNumber)
        {

            _accountNumber = AccountNumber;

        }

        public CheckingAccount(int AccountNumber, decimal AccountBalance)
        {
            _accountNumber = AccountNumber;
            _accountBalance = AccountBalance;

        }

        public CheckingAccount(int AccountNumber)
        {

            _accountNumber = AccountNumber;

        }
    }
}
