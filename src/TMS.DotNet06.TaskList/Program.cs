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

            taskList.ShowHeadLine();
            taskList.ShowMenu();
            taskList.MenuInputHanler();
        }
    }
}