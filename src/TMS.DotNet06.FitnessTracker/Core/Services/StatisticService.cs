using System;
using System.Collections.Generic;
using System.Text;
using TMS.DotNet06.FitnessTracker.Core.Interfaces;

namespace TMS.DotNet06.FitnessTracker.Core.Services
{
    class StatisticService : IStatisticService
    {
        public event Action<string, DateTime> StatusNotification;
        public event Action<string> ErrorNotification;

        public void GetCount()
        {
            throw new NotImplementedException();
        }

        public void GetPPM()
        {
            throw new NotImplementedException();
        }

        public void GetSpeed()
        {
            throw new NotImplementedException();
        }
    }
}
