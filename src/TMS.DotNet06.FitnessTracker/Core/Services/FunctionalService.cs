﻿using System;
using System.Linq;
using TMS.DotNet06.FitnessTracker.Core.Enums;
using TMS.DotNet06.FitnessTracker.Core.Interfaces;
using TMS.DotNet06.FitnessTracker.Core.Manager;
using TMS.DotNet06.FitnessTracker.Core.Models;
using TMS.DotNet06.FitnessTracker.Core.Services;

namespace TMS.DotNet06.FitnessTracker.Core.Services
{
    class FunctionalService : IFunctionalService
    {
        /// <summary>
        /// Event which shows status notifications
        /// </summary>
        public event Action<string> StatusNotification;
        /// <summary>
        /// Event which shows error notifications
        /// </summary>
        public event Action<string> ErrorNotification;
        /// <summary>
        /// Method to add exercises to user tracker
        /// </summary>
        /// <param name="user">User to which you want to add exercise</param>
        /// <param name="exercise">Exercise you want to add</param>
        /// <param name="exerciseStart">Date when you have done exercise</param>
        /// <param name="exerciseEnd">Date when you have finished exercise</param>
        /// <param name="units">Specific unit of exercise (distance\times etc.)</param>
        public void AddNewExercise(User user, Exercises exercise, DateTime exerciseStart, DateTime exerciseEnd, double units)
        {
            var statisticService = new StatisticService();
            statisticService.StatusNotification += NotificationManager.SendStatusNotification;
            statisticService.ErrorNotification += NotificationManager.SendErrorNotification;

            switch (exercise)
            {
                case Exercises.PushUps:
                    var newPushUps = new PushUpSeries
                    {
                        Name = $"PushUps #{user.PushUps.Count + 1}",
                        ExerciseStart = exerciseStart,
                        ExerciseEnd = exerciseEnd,
                        ExerciseTimeSpan = exerciseEnd - exerciseStart,
                        Count = (int)units,
                    };
                    user.PushUps.Add(newPushUps);
                    StatusNotification?.Invoke($"Push Ups #{user.PushUps.Count} for user {user.Name} successfully added!");
                    user.AvaragePushUps = statisticService.GetAverageStatistic(user, exercise);
                    break;

                case Exercises.Run:
                    var newRun = new Run
                    {
                        Name = $"Run #{user.Runs.Count + 1}",
                        ExerciseStart = exerciseStart,
                        ExerciseEnd = exerciseEnd,
                        ExerciseTimeSpan = exerciseEnd - exerciseStart,
                        Distance = units,
                    };
                    user.Runs.Add(newRun);
                    StatusNotification?.Invoke($"Run #{user.Runs.Count} for user {user.Name} successfully added!");
                    user.AvarageRunDistance = statisticService.GetAverageStatistic(user, exercise);
                    break;

                case Exercises.Squats:
                    var newSquats = new SquatSeries
                    {
                        Name = $"Squats #{user.Squats.Count + 1}",
                        ExerciseStart = exerciseStart,
                        ExerciseEnd = exerciseEnd,
                        ExerciseTimeSpan = exerciseEnd - exerciseStart,
                        Count = (int)units,
                    };
                    user.Squats.Add(newSquats);
                    StatusNotification?.Invoke($"Squats #{user.Squats.Count} for user {user.Name} successfully added!");
                    user.AvarageSquats = statisticService.GetAverageStatistic(user, exercise);
                    break;

                default:
                    ErrorNotification?.Invoke("No such Exercise!");
                    break;
            }
            user.AvarageExercisePulse = statisticService.GetPulsePerMinute(user, exercise);
        }
        /// <summary>
        /// Method which sort exercises by date and form them in trainings
        /// </summary>
        /// <param name="user">User whose trainings you want to see</param>
        public void ShowTrainings(User user)
        {
            Console.WriteLine($"\n-------{user.Name}`s trainings-------");
            var trainings = user.PushUps
                .Select(p => new
                {
                    p.Name,
                    Units = $"Number of times : {p.Count}",
                    Date = p.ExerciseStart,
                })
                    .Concat(user.Squats
                        .Select(s => new
                        {
                            s.Name,
                            Units = $"Number of times : {s.Count}",
                            Date = s.ExerciseStart,
                        })
                            .Concat(user.Runs
                            .Select(r => new
                            {
                                r.Name,
                                Units = $"Distance in meters: {r.Distance}",
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
        /// <summary>
        /// Method which shows progress of user in exercises
        /// </summary>
        /// <param name="user">User whose progress you want to see</param>
        public void ShowExersiseProgress(User user)
        {
            Console.WriteLine($"\n-------{user.Name}`s progress-------");
            Console.WriteLine("[Date] : [Times\\Distance] - [Time for exercise]");

            Console.WriteLine($"\nPush Ups of {user.Name}: ");
            foreach (var pushUps in user.PushUps)
            {
                Console.WriteLine($"[{pushUps.ExerciseStart.ToShortDateString()}] : [{pushUps.Count}] - [{pushUps.ExerciseTimeSpan}]");
            }

            Console.WriteLine($"\nRuns of {user.Name}: ");
            foreach (var run in user.Runs)
            {
                Console.WriteLine($"[{run.ExerciseStart.ToShortDateString()}] : [{run.Distance}] - [{run.ExerciseTimeSpan}]");
            }

            Console.WriteLine($"\nSquats of {user.Name}: ");
            foreach (var squats in user.Squats)
            {
                Console.WriteLine($"[{squats.ExerciseStart.ToShortDateString()}] : [{squats.Count}] - [{squats.ExerciseTimeSpan}]");
            }
            Console.WriteLine("\n-------------------------------");
        }
    }
}
