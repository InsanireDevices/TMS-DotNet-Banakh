using System;
using System.Globalization;

namespace TMS.DotNet06.DayInputHandler
{
    class Program
    {
        static void Main(string[] args)
        {

            DayInputHandler();

            Console.ReadKey();

            //Console.WriteLine("--------------------------------");

            //Console.WriteLine("START day : " + DayToStart.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
            //Console.WriteLine("END day : " + DayToEnd.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));

            //Console.WriteLine("--------------------------------");
            
            //DaySearch(DayToStart, DayToEnd);

        }

        static void DateOutputHandler(DateTime dayToStart, DateTime dayToEnd)
        {

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
                Console.WriteLine("Correct Input");
                DateOutputHandler(DayToStart, DayToEnd);
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error : END day is less than START day!");
                Console.ResetColor();

                DayInputHandler();
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
