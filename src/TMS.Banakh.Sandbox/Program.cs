using System;

namespace TMS.Banakh.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var penOne = new Pen();
            var penTwo = new Pen(123);

            Console.WriteLine(penOne);
            Console.WriteLine(penOne.Color);
            Console.WriteLine(penTwo);
            Console.WriteLine(penTwo.Color);

            Console.ReadKey();
        }
    }
}
