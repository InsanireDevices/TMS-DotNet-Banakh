using System;
using System.Collections.Generic;
using System.Text;
using TMS.DotNet06.ZooManager.Interfaces;

namespace TMS.DotNet06.ZooManager.Models
{
    class Wolf : AnimalBase, IMovable, ITalkative
    {

        public void Move()
        {
            Console.WriteLine("Wolf is moving!");
        }

        public void Say()
        {
            Console.WriteLine("АУФ!");
        }
    }
}
