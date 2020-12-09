using System.Collections.Generic;
using System.Globalization;
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

        public void ShowHeadLine()
        {
            Console.WriteLine("----------TASK TRACKER----------\n");
        }

        public void ShowMenu()
        {
            Console.WriteLine("-------MENU-------");
            Console.WriteLine("Add Task    -> [A]");
            Console.WriteLine("Edit Task   -> [E]");
            Console.WriteLine("Delete Task -> [D]");
            Console.WriteLine("Show Tasks  -> [S]");
            Console.WriteLine("Close App   -> [C]");
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
                case "C":
                    Environment.Exit(1);
                    break;
                default:
                    Console.Clear();
                    
                    ShowHeadLine();
                    
                    Console.WriteLine("ERROR : Invalid Input! Input listed characters in uppercase.\n");
                    
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

            ShowHeadLine();

            Console.WriteLine("------------------");
            Console.WriteLine("|   Add action   |");
            Console.WriteLine("------------------\n");

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
                Console.WriteLine("ERROR : END day is less than START day!");
                Console.ResetColor();

                goto dateInput;
            }

            #endregion

            taskCards.Add(new TaskCard(description, startDate, endDate));

            Console.Clear();
         
            ShowHeadLine();
            
            Console.WriteLine("Task created successfully!\n");
            
            ShowMenu();
            MenuInputHanler();
        }

        public void Edit()
        {
            Console.Clear();

            ShowHeadLine();

            Console.WriteLine("------------------");
            Console.WriteLine("|   Edit Task    |");
            Console.WriteLine("------------------\n");
            ShowMenu();
            MenuInputHanler();
        }

        public void Delete()
        {
            Console.Clear();

            ShowHeadLine();

            Console.WriteLine("------------------");
            Console.WriteLine("|  Delete Task   |");
            Console.WriteLine("------------------\n");
            ShowMenu();
            MenuInputHanler();
        }

        public void ShowTasks()
        {
            Console.Clear();

            ShowHeadLine();

            Console.WriteLine("------------------");
            Console.WriteLine("| Your Task List |");
            Console.WriteLine("------------------\n");

            if (this.taskCards.Count == 0)
            {
                Console.WriteLine("ERROR : Your Task List is Empty!\n");
            }

            else
            {
                for (int i = 0; i < this.taskCards.Count; i++)
                {
                    Console.WriteLine($"------Task {i + 1}------");
                    Console.WriteLine($"ID : {taskCards[i].ID}");
                    Console.WriteLine($"Description : {taskCards[i].Description}");
                    Console.WriteLine($"Timing :  {taskCards[i].StartDate.ToString("dd.MM.yyyy")} -> {taskCards[i].EndDate.ToString("dd.MM.yyyy")}");
                    Console.WriteLine($"Status : {taskCards[i].Status}");
                    Console.WriteLine("------------------\n");
                }
            }

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
                Console.WriteLine("ERROR : Input is Incorrect!");
                Console.ResetColor();

                Console.Write(request);

                return DateInputCheck(Console.ReadLine(), request);
            }
        }
    }
}
