using System;
using System.Linq;
using TMS.DotNet06.FitnessTracker.Core.Enums;
using TMS.DotNet06.FitnessTracker.Core.Interfaces;
using TMS.DotNet06.FitnessTracker.Core.Models;

namespace TMS.DotNet06.FitnessTracker.Core.Services
{
    class FunctionalService : IFunctionalService
    {
        public event Action<string> StatusNotification;
        public event Action<string> ErrorNotification;

        public void AddNewExercise(User user, Exercises exercise, DateTime exerciseStart, DateTime exerciseEnd, double units)
        {
            switch (exercise)
            {
                case Exercises.PushUps:
                    var newPushUps = new PushUpSeries
                    {
                        Name = $"PushUps #{user.PushUps.Count + 1}",
                        ExerciseStart = exerciseStart,
                        ExerciseEnd = exerciseEnd,
                        ExerciseTimeSpan = exerciseEnd - exerciseStart,
                        Units = (int)units,
                    };
                    user.PushUps.Add(newPushUps);
                    StatusNotification?.Invoke($"Push Ups #{user.PushUps.Count} for user {user.Name} successfully added!");
                    break;

                case Exercises.Run:
                    var newRun = new Run
                    {
                        Name = $"Run #{user.Runs.Count + 1}",
                        ExerciseStart = exerciseStart,
                        ExerciseEnd = exerciseEnd,
                        ExerciseTimeSpan = exerciseEnd - exerciseStart,
                        Units = units,
                    };
                    user.Runs.Add(newRun);
                    StatusNotification?.Invoke($"Run #{user.Runs.Count} for user {user.Name} successfully added!");
                    break;

                case Exercises.Squats:
                    var newSquats = new SquatSeries
                    {
                        Name = $"Squats #{user.Squats.Count + 1}",
                        ExerciseStart = exerciseStart,
                        ExerciseEnd = exerciseEnd,
                        ExerciseTimeSpan = exerciseEnd - exerciseStart,
                        Units = (int)units,
                    };
                    user.Squats.Add(newSquats);
                    StatusNotification?.Invoke($"Squats #{user.Squats.Count} for user {user.Name} successfully added!");
                    break;

                default:
                    ErrorNotification?.Invoke("No such Exercise!");
                    break;
            }
        }

        public void ShowTrainings(User user)
        {
            Console.WriteLine($"\n-------{user.Name}`s trainings-------");
            var trainings = user.PushUps
                .Select(p => new
                {
                    p.Name,
                    Units = $"Number of times : {p.Units}",
                    Date = p.ExerciseStart,
                })
                    .Concat(user.Squats
                        .Select(s => new
                        {
                            s.Name,
                            Units = $"Number of times : {s.Units}",
                            Date = s.ExerciseStart,
                        })
                            .Concat(user.Runs
                            .Select(r => new
                            {
                                r.Name,
                                Units = $"Distance in meters: {r.Units}",
                                Date = r.ExerciseStart,
                            })))
                    .OrderBy(t => t.Date);

            DateTime tempDate = new DateTime(0);
            
            foreach (var item in trainings)
            {
                if (tempDate.Date < item.Date.Date)
                {
                    tempDate = item.Date;
                    Console.WriteLine($"\nTraining on {item.Date.ToShortDateString()}");
                }
                Console.WriteLine($"{item.Name} { item.Units}");
            }
            Console.WriteLine("\n-------------------------------");
        }

        public void ShowExersiseProgress(User user)
        {
            Console.WriteLine($"\n-------{user.Name}`s progress-------");
            Console.WriteLine("[Date] : [Times\\Distance] - [Time for exercise]");

            Console.WriteLine($"\nPush Ups of {user.Name}: ");
            foreach (var pushUps in user.PushUps)
            {
                Console.WriteLine($"[{pushUps.ExerciseStart.ToShortDateString()}] : [{pushUps.Units}] - [{pushUps.ExerciseTimeSpan}]");
            }

            Console.WriteLine($"\nRuns of {user.Name}: ");
            foreach (var run in user.Runs)
            {
                Console.WriteLine($"[{run.ExerciseStart.ToShortDateString()}] : [{run.Units}] - [{run.ExerciseTimeSpan}]");
            }

            Console.WriteLine($"\nSquats of {user.Name}: ");
            foreach (var squats in user.Squats)
            {
                Console.WriteLine($"[{squats.ExerciseStart.ToShortDateString()}] : [{squats.Units}] - [{squats.ExerciseTimeSpan}]");
            }
            Console.WriteLine("\n-------------------------------");
        }
    }
}
