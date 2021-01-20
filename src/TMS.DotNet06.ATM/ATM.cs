using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.ATM
{
    class ATM
    {
        private delegate void AccountHandler(string message);

        private event AccountHandler Notify;
        private event AccountHandler NotifyError;

        private BankAccount bankAccount { get; set; }

        public ATM(BankAccount account)
        {
            bankAccount = account;
            this.Notify += SendPushNotification;
            this.NotifyError += SendErrorNotification;
        }
        
        public void ShowMenu()
        {
            Console.WriteLine("-------------MENU------------");
            Console.WriteLine("Top Up Account         -> [T]");
            Console.WriteLine("Withdraw From Account  -> [W]");
            Console.WriteLine("Display Actual Balance -> [D]");
            Console.WriteLine("Close App              -> [C]");
            Console.WriteLine("------------------------------\n");
            MenuInputHandler();
        }

        private void MenuInputHandler()
        {
            string actionSelector;

            Console.Write("Choose Action : ");

            actionSelector = Console.ReadLine();

            switch (actionSelector)
            {
                case "T":
                    TopUpAccount();
                    break;
                case "W":
                    WithdrawFromAccount();
                    break;
                case "D":
                    DisplayActualBalance();
                    break;
                case "C":
                    Environment.Exit(1);
                    break;
                default:
                    MenuInputHandler();
                    break;
            }
        }

        private void TopUpAccount()
        {
            decimal topedUp = bankAccount.CoinsParser();
            bankAccount.AccountAmount += topedUp;
            Notify?.Invoke($"Account topped up with {topedUp} coins");
            ShowMenu();
        }

        private void WithdrawFromAccount()
        {
            decimal withdrawed = bankAccount.CoinsParser();
            if (withdrawed <= bankAccount.AccountAmount)
            {
                bankAccount.AccountAmount -= withdrawed;
                Notify?.Invoke($"From Account Withdrawed {withdrawed} coins");
            }
            else
            {
                NotifyError?.Invoke($"Insufficient Funds!");
            }
            ShowMenu();
        }

        private void DisplayActualBalance()
        {
            Notify?.Invoke($"Account Actual Balance {bankAccount.AccountAmount} coins");
            ShowMenu();
        }

        private void SendPushNotification(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Push-notification : {notification}");
            Console.ResetColor();
        }

        private void SendErrorNotification(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR : {error}");
            Console.ResetColor();
        }
    }
}
