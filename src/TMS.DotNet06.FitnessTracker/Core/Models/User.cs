﻿using System.Collections.Generic;
using TMS.DotNet06.FitnessTracker.Core.Enums;

namespace TMS.DotNet06.FitnessTracker.Core.Models
{
    class User
    {
        /// <summary>
        /// Constructor of User entity
        /// </summary>
        /// <param name="name">User name</param>
        /// <param name="weight">User weight</param>
        /// <param name="height">User height</param>
        /// <param name="age">User age</param>
        /// <param name="sex">User sex</param>
        public User(string name, double weight, double height, int age, Sex sex)
        {
            Name = name;
            this.Weight = weight;
            this.Height = height;
            this.Age = age;
            this.Sex = sex;
        }
        /// <summary>
        /// User Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// User weigth in killogramms
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// User height in santimeters
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// User age in years
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// User sex
        /// </summary>
        public Sex Sex { get; set; }
        /// <summary>
        /// List of all user runs
        /// </summary>
        public List<Run> Runs { get; set; } = new List<Run>();
        /// <summary>
        /// Avarage distance of User runs
        /// </summary>
        public double AvarageRunDistance { get; set; }
        /// <summary>
        /// List of all user push up series
        /// </summary>
        public List<PushUpSeries> PushUps { get; set; } = new List<PushUpSeries>();
        /// <summary>
        /// Avarage user push-ups count
        /// </summary>
        public double AvaragePushUps { get; set; }
        /// <summary>
        /// List of all user squat series
        /// </summary>
        public List<SquatSeries> Squats { get; set; } = new List<SquatSeries>();
        /// <summary>
        /// Avarage user squats count
        /// </summary>
        public double AvarageSquats { get; set; }
        /// <summary>
        /// Avarage pulse during exercises
        /// </summary>
        public int AvarageExercisePulse { get; set; }
    }
}
