using System;
using System.Collections.Generic;
using System.Text;
using TMS.DotNet06.ZooManager.Interfaces;

namespace TMS.DotNet06.ZooManager.Models
{
    public class Fox : AnimalBase, IMovable, ITalkative
    {
        public void Move()
        {
            Console.WriteLine("Fox is moving!");
        }

        public void Say()
        {
            Console.WriteLine("What does the fox say?");
        }
    }
}
