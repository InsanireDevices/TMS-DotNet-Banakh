using System;

namespace TMS.DotNet06.ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            var cashOMate = new ATM(account);           
            cashOMate.ShowMenu();
            Console.ReadKey();
        }
    }
}
