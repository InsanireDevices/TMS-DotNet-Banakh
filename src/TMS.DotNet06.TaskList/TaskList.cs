
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
        }

        public void MenuInputHanler() 
        {
            string key;

            Console.Write("Choose action : ");
            key = Console.ReadLine();

            switch (key)
            {
                case "A":
                    Add();
                    break;
                case "E":
                    Edit();
                    break;
                case "D":
                    Delete();
                    break;
                case "S":
                    ShowTasks();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("ERROR : Invalid Input! Input listed characters in uppercase.\n");
                    ShowMenu();
                    MenuInputHanler();
                    break;
            }
        }

        public void ShowTasks()
        {
            Console.Clear();
            Console.WriteLine("--------");
            Console.WriteLine("ShowTasks");
            Console.WriteLine("--------");
            ShowMenu();
            MenuInputHanler();
        }

        public void Add()
        {
            Console.Clear();
            Console.WriteLine("--------");
            Console.WriteLine("Add");
            Console.WriteLine("--------");
            ShowMenu();
            MenuInputHanler();
        }

        public void Edit()
        {
            Console.Clear();
            Console.WriteLine("--------");
            Console.WriteLine("Edit");
            Console.WriteLine("--------");
            ShowMenu();
            MenuInputHanler();
        }

        public void Delete()
        {
            Console.Clear();
            Console.WriteLine("--------");
            Console.WriteLine("Delete");
            Console.WriteLine("--------");
            ShowMenu();
            MenuInputHanler();
        }
    }
}
