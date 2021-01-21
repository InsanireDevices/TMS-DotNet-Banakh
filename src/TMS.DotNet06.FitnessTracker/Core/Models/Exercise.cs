using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.FitnessTracker.Core.Models
{
    abstract class Exercise<T>
    {
        /// <summary>
        /// Name of exercise
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date when User start exercise
        /// </summary>
        public DateTime ExerciseStart { get; set; }
        /// <summary>
        /// Date when User end exercise
        /// </summary>
        public DateTime ExerciseEnd { get; set; }
        /// <summary>
        /// Time span which exercise took
        /// </summary>
        public TimeSpan ExerciseTimeSpan { get; set; }
        /// <summary>
        /// Specific units of measurements for exercise
        /// </summary>
        public T Units { get; set; }
    }
}
