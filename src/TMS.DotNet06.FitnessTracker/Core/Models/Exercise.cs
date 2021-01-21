using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.FitnessTracker.Core.Models
{
    abstract class Exercise<T>
    {
        public string Name { get; set; }
        public DateTime ExerciseStart { get; set; }
        public DateTime ExerciseEnd { get; set; }
        public TimeSpan ExerciseTimeSpan { get; set; }
        public T Units { get; set; }
    }
}
