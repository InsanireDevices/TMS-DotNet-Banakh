using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.ATM
{
    class BankAccount
    {
        public decimal AccountAmount { get; private set; }
        public BankAccount(decimal accountAmount)
        {
            AccountAmount = accountAmount;
        }
    }
}
