using System;
using System.Collections.Generic;
using System.Text;
using TMS.DotNet06.FitnessTracker.Core.Enums;

namespace TMS.DotNet06.FitnessTracker.Core.Models
{
    class User
    {
        public User(string name, double weight, double height, int age, Sex sex)
        {
            Name = name;
            this.Weight = weight;
            this.Height = height;
            this.Age = age;
            this.Sex = sex;
        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public  Sex Sex { get; set; }

        public List<Run> Runs { get; set; } = new List<Run>();
        public List<PushUps> PushUps { get; set; } = new List<PushUps>();
        public List<Squats> Squats { get; set; } = new List<Squats>();
    }
}
