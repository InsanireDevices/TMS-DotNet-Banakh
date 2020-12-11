using System;

namespace TMS.DotNet06.DateInputHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateRequest = "Please enter date : ";
            DateTime inputDate;

            Console.Write(dateRequest);
            inputDate = DateInputHandler(Console.ReadLine(), dateRequest);
            Console.Write($"Day is : {inputDate.DayOfWeek}\n");
            Console.WriteLine("Press any key to close app.");
            Console.ReadKey();
        }

        static DateTime DateInputHandler(string DateToCheck, string request)
        {
            DateTime dateOutput;
            try
            {    
                dateOutput = DateTime.Parse(DateToCheck);
                return dateOutput;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Incorrect input!");
                return DateInputHandler(Console.ReadLine(), request);
            }
        }
    }
}
