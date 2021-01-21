using System;
using TMS.DotNet06.FitnessTracker.Core.Enums;
using TMS.DotNet06.FitnessTracker.Core.Models;

namespace TMS.DotNet06.FitnessTracker.Core.Interfaces
{
    interface IFunctionalService
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
        /// Method which sort exercises by date and form them in trainings
        /// </summary>
        /// <param name="user">User whose trainings you want to see</param>
        void ShowTrainings(User user);
        /// <summary>
        /// Method which shows progress of user in exercises
        /// </summary>
        /// <param name="user">User whose progress you want to see</param>
        void ShowExersiseProgress(User user);
        /// <summary>
        /// Method to add exercises to user tracker
        /// </summary>
        /// <param name="user">User to which you want to add exercise</param>
        /// <param name="exercise">Exercise you want to add</param>
        /// <param name="exerciseStart">Date when you have done exercise</param>
        /// <param name="exerciseEnd">Date when you have finished exercise</param>
        /// <param name="units">Specific unit of exercise (distance\times etc.)</param>
        void AddNewExercise(User user, Exercises exercise, DateTime exerciseStart, DateTime exerciseEnd, double units);
    }
}
