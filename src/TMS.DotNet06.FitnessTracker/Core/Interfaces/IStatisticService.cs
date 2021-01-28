using System;
using TMS.DotNet06.FitnessTracker.Core.Enums;
using TMS.DotNet06.FitnessTracker.Core.Models;

namespace TMS.DotNet06.FitnessTracker.Core.Interfaces
{
    interface IStatisticService
    {
        /// <summary>
        /// Event which shows status notifications
        /// </summary>
        event Action<string> StatusNotification;
        /// <summary>
        /// Event which shows error notifications
        /// </summary>
        event Action<string> ErrorNotification;
        /// <summary>
        /// Method to get pulse of User during exercise
        /// </summary>
        /// <param name="user">User whose pulse you want to get </param>
        /// <param name="exercise">Specify exercise</param>
        /// <returns></returns>
        int GetPulsePerMinute(User user, Exercises exercise);
        /// <summary>
        /// Method to get avarage statistic about User in exercises
        /// </summary>
        /// <param name="user">User whose avarage statistic you whant to get</param>
        /// <param name="exercise">Specify exercise</param>
        /// <returns></returns>
        double GetAverageStatistic(User user, Exercises exercise);
    }
}
