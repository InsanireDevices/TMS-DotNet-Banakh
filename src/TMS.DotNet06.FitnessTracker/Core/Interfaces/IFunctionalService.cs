using System;
using TMS.DotNet06.FitnessTracker.Core.Enums;
using TMS.DotNet06.FitnessTracker.Core.Models;

namespace TMS.DotNet06.FitnessTracker.Core.Interfaces
{
    interface IFunctionalService
    {
        event Action<string> StatusNotification;
        event Action<string> ErrorNotification;

        void ShowTrainings(User user);
        void ShowExersiseProgress(User user);
        void AddNewExercise(User user, Exercises exercise, DateTime exerciseStart, DateTime exerciseEnd, double units);
    }
}
