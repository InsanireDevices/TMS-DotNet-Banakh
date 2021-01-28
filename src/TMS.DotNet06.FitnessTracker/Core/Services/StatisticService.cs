using System;
using System.Collections.Generic;
using System.Text;
using TMS.DotNet06.FitnessTracker.Core.Enums;
using TMS.DotNet06.FitnessTracker.Core.Interfaces;
using TMS.DotNet06.FitnessTracker.Core.Models;
using System.Linq;

namespace TMS.DotNet06.FitnessTracker.Core.Services
{
    class StatisticService : IStatisticService
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
        /// Method to get avarage statistic about User in exercises
        /// </summary>
        /// <param name="user">User whose avarage statistic you whant to get</param>
        /// <returns></returns>
        public double GetAverageStatistic(User user, Exercises exercise)
        {
            switch(exercise)
            {
                case Exercises.PushUps:
                    return user.PushUps.Average(a => a.Count);

                case Exercises.Run:
                    return user.Runs.Average(a => a.Distance);

                case Exercises.Squats:
                    return user.Squats.Average(a => a.Count);
                default:
                    ErrorNotification?.Invoke("No such exercise!");
                    return -1;
            }
        }

        /// <summary>
        /// Method to get pulse of User during exercise
        /// </summary>
        /// <param name="user">User whose pulse you want to get </param>
        /// <returns></returns>
        public int GetPulsePerMinute(User user, Exercises exercise)
        {
            var randomPulse = new Random();
            StatusNotification?.Invoke("Pulse statistic ready!");
            return randomPulse.Next(60,120);
        }
    }
}
