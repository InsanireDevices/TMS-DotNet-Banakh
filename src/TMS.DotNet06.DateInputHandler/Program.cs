using System;

namespace TMS.DotNet06.DateInputHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DateToCheck;
            Boolean DateIsCorrect = false;
            
            while(!DateIsCorrect)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Please enter date : ");
                    Console.ResetColor();

                    DateToCheck = DateTime.Parse(Console.ReadLine());         
                    
                    Console.Write("Day is : ");
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(DateToCheck.DayOfWeek + "\n");
                    Console.ResetColor();
                    
                    DateIsCorrect = true;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Incorrect date! Please, enter date in yyyy-mm-dd format.");
                    Console.ResetColor();
                }
            }

            Console.WriteLine("Press any key to close app.");
            Console.ReadKey();
        }
    }
}
