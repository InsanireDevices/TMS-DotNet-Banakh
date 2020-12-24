using System;

namespace TMS.DotNet06.ZooManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var westCoastZoo = new Managers.ZooManager("West Coast Zoo");

            westCoastZoo.MenuHandler();
        }
    }
}
