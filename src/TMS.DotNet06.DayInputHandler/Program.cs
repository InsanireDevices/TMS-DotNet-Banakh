using System;

namespace TMS.DotNet06.DayInputHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DayToStart;
            DateTime DayToEnd;

            Console.Write("Enter START day : ");
            DayToStart = DayInputCheck(Console.ReadLine(), "Enter START day : ");

            Console.WriteLine("Enter END day : ");
            DayToEnd = DayInputCheck(Console.ReadLine(), "Enter END day:");
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
