
using System.Collections.Generic;
using System.Linq;
using System;

namespace TMS.DotNet06.TaskList
{
    class TaskList
    {
        public IList<TaskCard> taskCards;

        public TaskList(IList<TaskCard> taskCards)
        {
            taskCards = new List<TaskCard>();
            this.taskCards = taskCards;
        }

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
            string actionSelector;

            Console.Write("Choose action : ");
            actionSelector = Console.ReadLine();

            switch (actionSelector)
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
                    Console.WriteLine("\nERROR : Invalid Input! Input listed characters in uppercase.\n");
                    ShowMenu();
                    MenuInputHanler();
                    break;
            }
        }

        public void Add()
        {
            string description;
            DateTime startDate;
            DateTime endDate;

            Console.Clear();

            Console.WriteLine("-------------");
            Console.WriteLine("Add action : ");
            Console.WriteLine("-------------\n");

            Console.Write("Enter Description : ");
            description = Console.ReadLine();

            #region Date Input

            dateInput:

            Console.Write("Ented Start Date : ");
            startDate = DateInputCheck(Console.ReadLine(), "Ented Start Date : ");

            Console.Write("Enter End Date : ");
            endDate = DateInputCheck(Console.ReadLine(), "Enter End Date : ");

            if (startDate > endDate)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error : END day is less than START day!");
                Console.ResetColor();

                goto dateInput;
            }

            #endregion

            taskCards.Add(new TaskCard(description, startDate, endDate));


            Console.WriteLine("Task created successfully!");
            
            ShowTasks();
            
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
        public void ShowTasks()
        {
            Console.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("Your Task List");
            Console.WriteLine("--------------");

            Console.WriteLine($"{taskCards[0].ID}");
            Console.WriteLine($"{taskCards[0].Description}");
            Console.WriteLine($"{taskCards[0].StartDate} -> {taskCards[0].EndDate}");
            Console.WriteLine($"{taskCards[0].Status}");
            TaskCard specifictaskcard = taskCards.FirstOrDefault(a => a.ID == taskCards[0].ID);

            ShowMenu();
            MenuInputHanler();
        }

        private static DateTime DateInputCheck(string dayInput, string request)
        {
            DateTime dayOutput;

            try
            {
                return dayOutput = DateTime.Parse(dayInput);
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error : Input is Incorrect!");
                Console.ResetColor();

                Console.Write(request);

                return DateInputCheck(Console.ReadLine(), request);
            }
        }
    }
}
