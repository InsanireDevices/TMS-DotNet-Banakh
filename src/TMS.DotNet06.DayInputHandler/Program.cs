using System;
using System.Globalization;

namespace TMS.DotNet06.DayInputHandler
{
    class Program
    {
        static void Main(string[] args)
        {

            DayInputHandler();

            Console.WriteLine("Press any key to close app.");
            Console.ReadKey();

        }

        static void DayInputHandler()
        {
            DateTime DayToStart;
            DateTime DayToEnd;

            Console.Write("Enter START day : ");
            DayToStart = DayInputCheck(Console.ReadLine(), "Enter START day : ");

            Console.Write("Enter END day : ");
            DayToEnd = DayInputCheck(Console.ReadLine(), "Enter END day : ");

            if (DayToStart < DayToEnd)
            {
                DayOutputHandler(DayToStart, DayToEnd);
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error : END day is less than START day!");
                Console.ResetColor();

                DayInputHandler();
            }
                
        }
        static void DayOutputHandler(DateTime dayToStart, DateTime dayToEnd)
        {
            DayOfWeek dayOfWeek;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("START day : " + dayToStart.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
            Console.WriteLine("END day : " + dayToEnd.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
            Console.WriteLine("--------------------------------");

            Console.Write("Enter DAY OF WEEK to search : ");

            dayOfWeek = DayOfWeekInputCheck(Console.ReadLine(), "Enter DAY OF WEEK to search: ");

            Console.WriteLine("DAY OF WEEK entered : " + dayOfWeek);
            Console.WriteLine("--------------------------------");

            while (dayToEnd >= dayToStart)
            {
                if (dayToStart.DayOfWeek == dayOfWeek)
                {
                    Console.WriteLine(dayToStart.ToString("dd/MM/yyyy - dddd", CultureInfo.InvariantCulture));
                }
                dayToStart = dayToStart.AddDays(1);
            }

        }

        static DayOfWeek DayOfWeekInputCheck(string dayOfWeekInput, string request)
        {
            try
            {
                DayOfWeek dayOfWeek  = Enum.Parse<DayOfWeek>(dayOfWeekInput);
                return dayOfWeek;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error : Invalid Input!");
                Console.ResetColor();

                Console.Write(request);

                return DayOfWeekInputCheck(Console.ReadLine(), request);
            }
        }

        static DateTime DayInputCheck(string dayInput, string request)
        {
            DateTime dayOutput;

            try
            {
                return dayOutput = DateTime.Parse(dayInput);
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error : Input is Incorrect!");
                Console.ResetColor();

                Console.Write(request);

                return DayInputCheck(Console.ReadLine(),request);
            }
                
        }
    }
 }
