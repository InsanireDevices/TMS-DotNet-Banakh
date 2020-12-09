using System;
using System.Collections.Generic;
using System.Linq;
namespace TMS.DotNet06.TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<TaskCard> taskCards = null;
            TaskList taskList = new TaskList(taskCards);      

            Console.WriteLine("----------TASK TRACKER----------\n");
            
            taskList.ShowMenu();
            taskList.MenuInputHanler();

            //IList<TaskCard> taskCards = new List<TaskCard>();
            //taskCards.Add(new TaskCard("My description", DateTime.Now, DateTime.Now.AddDays(1)));
            //Console.WriteLine($"{taskCards[0].ID}");
            //Console.WriteLine($"{taskCards[0].Description}");
            //Console.WriteLine($"{taskCards[0].StartDate} -> {taskCards[0].EndDate}");
            //Console.WriteLine($"{taskCards[0].Status}");
            //TaskCard specifictaskcard = taskCards.FirstOrDefault(a => a.ID == taskCards[0].ID);

            Console.WriteLine("Press any key to close app.");
            Console.ReadKey();
        }
    }
}