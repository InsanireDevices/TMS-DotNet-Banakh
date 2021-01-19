using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.ATM
{
    class ATM
    {
        public ATM()
        {
        }
        
        void ShowMenu()
        {
            Console.WriteLine("-------------MENU------------");
            Console.WriteLine("Top Up Account         -> [T]");
            Console.WriteLine("Withdraw From Account  -> [W]");
            Console.WriteLine("Display Actual Balance -> [D]");
            Console.WriteLine("Close App              -> [C]");
            Console.WriteLine("------------------------------\n");
        }

        void MenuInputHandler()
        {
            string actionSelector;

            Console.WriteLine("Choose Action : ");

            actionSelector = Console.ReadLine();

            switch (actionSelector)
            {
                case "T":
                    break;
                case "W":
                    break;
                case "C":
                    Environment.Exit(1);
                    break;
                default:
                    MenuInputHandler();
                    break;
            }
        }
    }
}
