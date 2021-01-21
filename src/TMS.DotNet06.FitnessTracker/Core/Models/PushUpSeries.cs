using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.FitnessTracker.Core.Models
{
    class PushUpSeries : Exercise<int>
    {
        /// <summary>
        /// Count of push-ups
        /// </summary>
        public int Count { get; set; }
    }
}
