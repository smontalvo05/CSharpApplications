using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stevemontalvo_CE02
{
    class CheckingAccount
    {
        decimal _accountBalance;
        int _accountNumber;

        public int GetAccountNumber()
        {
            return _accountNumber;
        }

        public void SetAccountNumber(int accountNumber)
        {
            _accountNumber = accountNumber;
        }

        public decimal GetAccountBalance()
        {
            return _accountBalance;

        }

        public void SetAccountBalance(decimal accountBalance)
        {
            _accountBalance = accountBalance;
        }

        public CheckingAccount (decimal accountBalance, int accountNumber)
        {
            _accountBalance = accountBalance;
            _accountNumber = accountNumber;

        }
    }
}
