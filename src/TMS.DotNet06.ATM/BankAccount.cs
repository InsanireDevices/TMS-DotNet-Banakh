using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.ATM
{
    public class BankAccount
    {
        public decimal AccountAmount { get; set; }
        public BankAccount()
        {
            decimal accountAmount = CoinsParser();
            AccountAmount = accountAmount;
        }

        public decimal CoinsParser()
        {
            decimal accountAmount;
            try
            {
                Console.Write("Enter the desired amount of coins : ");
                return accountAmount = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR : Invalid Input!");
                Console.ResetColor();
                return CoinsParser();
            }
        }
    }
}
