using System;
using System.Collections.Generic;
using System.Text;

namespace Review.Bank_Account_Manager
{
    internal interface IBankOperations
    {
        void Deposit(double balance);
        void Withdraw(double balance);
        void CheckBalance();
    }
}
