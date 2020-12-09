using System;
using System.Collections.Generic;
using System.Linq;
namespace TMS.DotNet06.TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskList taskList = new TaskList();
            IList<TaskCard> taskCards = new List<TaskCard>();

            

            Console.WriteLine("----------TASK TRACKER----------\n");
            
            taskList.ShowMenu();
            taskList.MenuInputHanler();

            Console.WriteLine("Press any key to close app.");
            Console.ReadKey();
        }
    }
}