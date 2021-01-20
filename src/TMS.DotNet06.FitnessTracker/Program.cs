using System;
using TMS.DotNet06.FitnessTracker.Core.Models;
using TMS.DotNet06.FitnessTracker.Core.Enums;
namespace TMS.DotNet06.FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Fitness Tracker!");
            // Add User Entity
            var user = new User("StronkAsFuck", 75, 182, 25, Sex.Male);

            Console.ReadKey();
        }
    }
}
