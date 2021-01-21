using System;
using System.Collections.Generic;
using System.Text;
using TMS.DotNet06.FitnessTracker.Core.Models;

namespace TMS.DotNet06.FitnessTracker.Core.Interfaces
{
    interface IStatisticService
    {
        event Action<string> StatusNotification;
        event Action<string> ErrorNotification;

        int GetPulsePerMinure(User user);
        int GetCount(User user);
        double GetSpeed(User user);
    }
}
