using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.FitnessTracker.Core.Models
{
    class Run : Exercise<double>
    {
        public double Speed { get; set; }
    }
}
