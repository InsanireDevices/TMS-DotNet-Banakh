using System;
using TMS.DotNet06.FitnessTracker.Core.Enums;
using TMS.DotNet06.FitnessTracker.Core.Manager;
using TMS.DotNet06.FitnessTracker.Core.Models;
using TMS.DotNet06.FitnessTracker.Core.Services;

namespace TMS.DotNet06.FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Fitness Tracker!\n");

            //Some initializations for services and events
            var functioalService = new FunctionalService();
            functioalService.StatusNotification += NotificationManager.SendStatusNotification;
            functioalService.ErrorNotification += NotificationManager.SendErrorNotification;
            

            // Add User Entity
            var habib = new User("Хабиб", 75, 182, 25, Sex.Male);

            // Show Our User Info
            Console.WriteLine($"{habib.Name}`s parameters :\n");
            Console.WriteLine($"Weight : {habib.Weight}");
            Console.WriteLine($"Height : {habib.Height}");
            Console.WriteLine($"Age    : {habib.Age}");
            Console.WriteLine($"Sex    : {habib.Sex}\n");

            // Add Some Exercises To Our User
            functioalService.AddNewExercise(habib, Exercises.PushUps, new DateTime(2021, 01, 12, 8, 30, 0), new DateTime(2021, 01, 12, 9, 30, 0), 50);
            functioalService.AddNewExercise(habib, Exercises.PushUps, new DateTime(2021, 01, 13, 8, 30, 0), new DateTime(2021, 01, 13, 9, 30, 0), 60);
            functioalService.AddNewExercise(habib, Exercises.PushUps, new DateTime(2021, 01, 14, 8, 30, 0), new DateTime(2021, 01, 14, 9, 30, 0), 70);

            functioalService.AddNewExercise(habib, Exercises.Squats, new DateTime(2021, 01, 12, 9, 35, 0), new DateTime(2021, 01, 12, 10, 35, 0), 100);
            functioalService.AddNewExercise(habib, Exercises.Squats, new DateTime(2021, 01, 13, 9, 35, 0), new DateTime(2021, 01, 13, 10, 35, 0), 110);
            functioalService.AddNewExercise(habib, Exercises.Squats, new DateTime(2021, 01, 14, 9, 35, 0), new DateTime(2021, 01, 14, 10, 35, 0), 120);
            
            functioalService.AddNewExercise(habib, Exercises.Run, new DateTime(2021, 01, 12, 10, 40, 0), new DateTime(2021, 01, 12, 11, 45, 0), 9000);
            functioalService.AddNewExercise(habib, Exercises.Run, new DateTime(2021, 01, 13, 10, 40, 0), new DateTime(2021, 01, 13, 11, 45, 0), 10000);
            functioalService.AddNewExercise(habib, Exercises.Run, new DateTime(2021, 01, 14, 10, 40, 0), new DateTime(2021, 01, 14, 11, 45, 0), 11000);

            //Show Our User Activities
            functioalService.ShowTrainings(habib);
            functioalService.ShowExersiseProgress(habib);

            //Show User Statistic
            Console.WriteLine($"Push-ups in avarage : {habib.AvaragePushUps}");
            Console.WriteLine($"Run distanse in avarage : {habib.AvarageRunDistance}");
            Console.WriteLine($"Squats in avarage : {habib.AvarageSquats}");
            Console.WriteLine($"Avarage pulse : {habib.AvarageExercisePulse}");

            Console.ReadKey();
        }
    }
}
