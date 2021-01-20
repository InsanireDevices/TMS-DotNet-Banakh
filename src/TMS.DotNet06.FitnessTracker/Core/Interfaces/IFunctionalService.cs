using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.FitnessTracker.Core.Interfaces
{
    interface IFunctionalService
    {
        event Action<string, DateTime> StatusNotification;
        event Action<string> ErrorNotification;

        void ShowExerciseStatistic();
        void ShowFullStatistic();
        void AddNewStatistic();
    }
}
