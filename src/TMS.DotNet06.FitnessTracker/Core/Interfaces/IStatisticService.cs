using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.FitnessTracker.Core.Interfaces
{
    interface IStatisticService
    {
        event Action<string, DateTime> StatusNotification;
        event Action<string> ErrorNotification;

        void GetPPM();
        void GetCount();
        void GetSpeed();
    }
}
