using System;
using System.Collections.Generic;
using System.Text;
using TMS.DotNet06.FitnessTracker.Core.Interfaces;
using TMS.DotNet06.FitnessTracker.Core.Models;

namespace TMS.DotNet06.FitnessTracker.Core.Services
{
    class StatisticService : IStatisticService
    {
        public event Action<string> StatusNotification;
        public event Action<string> ErrorNotification;

        public int GetCount(User user)
        {
            var count = 0;
            return count;
        }

        public int GetPulsePerMinure(User user)
        {
            var pulse = 0;
            return pulse;
        }

        public double GetSpeed(User user)
        {
            var speed = 0;
            return speed;
        }
    }
}
