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
                    Console.Write("Please enter date : ");
                    DateToCheck = DateTime.Parse(Console.ReadLine());                           
                    Console.Write("Day is : ");
                    Console.Write(DateToCheck.DayOfWeek + "\n");   
                    DateIsCorrect = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Incorrect date! Please, enter date in yyyy-mm-dd format.");
                }
            }

            Console.WriteLine("Press any key to close app.");
            Console.ReadKey();
        }
    }
}
