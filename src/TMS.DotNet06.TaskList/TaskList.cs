
using System.Collections.Generic;
using System.Text;
using System;

namespace TMS.DotNet06.TaskList
{
    class TaskList
    {
        public void ShowMenu()
        {
            Console.WriteLine("-------MENU-------");
            Console.WriteLine("Add Task    -> [A]");
            Console.WriteLine("Edit Task   -> [E]");
            Console.WriteLine("Delete Task -> [D]");
            Console.WriteLine("Show Tasks  -> [S]");
            Console.WriteLine("------------------\n");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            switch(key)
            {
                case (key.KeyChar = 'a')
            }
        }

        public void ShowTasks()
        {
            ShowMenu();   
        }

        public void Add()
        {
            ShowMenu();
        }

        public void Edit()
        {
            ShowMenu();
        }

        public void Delete()
        {
            ShowMenu();
        }
    }
}
