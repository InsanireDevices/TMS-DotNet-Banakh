using System;
using TMS.Banakh.Sandbox._24._12._2020;

namespace TMS.Banakh.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var delegateTest = new Delegates("kokoko");
            delegateTest.message1 = (int num, string str) =>
            {
                Console.WriteLine("hohoh");
                return true;
            };
            //delegateTest.message1 = delegateTest.ShowMessage;
            delegateTest.message1(1, "lolool");

            Action<int> action = (int num) =>
            {
                Console.WriteLine(num);
            };

            Predicate<int> predicate = (num) => { return num > 0; };

            Func<int, string> func = (num) => { return num.ToString(); };

            Console.WriteLine(func(12));

            Console.WriteLine(predicate(-1));

            action(10);

            Console.ReadKey();
        }


    }
}
