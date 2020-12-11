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

        private void Add()
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

            TimingInputHandler(out startDate, out endDate);

            taskCards.Add(new TaskCard(description, startDate, endDate));

            Console.Clear();        
            ShowHeadLine();            
            Console.WriteLine("Task created successfully!\n");            
            ShowMenu();
            MenuInputHanler();
        }

        private void Edit()
        {
            string description;
            DateTime startDate;
            DateTime endDate;
            string status;
            int task;

            Console.Clear();
            ShowHeadLine();
            Console.WriteLine("------------------");
            Console.WriteLine("|   Edit Task    |");
            Console.WriteLine("------------------\n");

            if (this.taskCards.Count == 0)
            {
                Console.Clear();
                ShowHeadLine();
                Console.WriteLine("ERROR : Your Task List is Empty!\n");
                ShowMenu();
                MenuInputHanler();
            }
            else
            {
                for (int i = 0; i < this.taskCards.Count; i++)
                {
                    ShowTaskCard(i);
                }

                task = TaskNumberInputHandler();

                Console.Clear();
                ShowHeadLine();
                Console.WriteLine("------------------");
                Console.WriteLine("|   Edit Task    |");
                Console.WriteLine("------------------\n");
                
                ShowTaskCard(task);

                Console.Write("Enter Description : ");
                description = Console.ReadLine();

                TimingInputHandler(out startDate, out endDate);
//-------------------------------------------------------------------------------------------------------
            statusInput:
                Console.Write("Enter ToDo\\InProgress\\Done Status : ");
                try
                {
                    status = Enum.Parse<TaskCard.StatusList>(Console.ReadLine()).ToString();
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR : Status can take only next values : ToDo, InProgress, Done");
                    Console.ResetColor();
                    goto statusInput;
                }
//---------------------------------------------------------------------------------------------------------------                
                taskCards[task].Description = description;
                taskCards[task].StartDate = startDate;
                taskCards[task].EndDate = endDate;
                taskCards[task].Status = status;

                Console.Clear();
                ShowHeadLine();
                Console.WriteLine("Task succesfully edited!\n");
                ShowMenu();
                MenuInputHanler();
            }

            ShowMenu();
            MenuInputHanler();
        }

        private void Delete()
        {
            int task;
            Console.Clear();
            ShowHeadLine();
            Console.WriteLine("------------------");
            Console.WriteLine("|  Delete Task   |");
            Console.WriteLine("------------------\n");

            if (this.taskCards.Count == 0)
            {
                Console.Clear();
                ShowHeadLine();               
                Console.WriteLine("ERROR : Your Task List is Empty!\n");             
                ShowMenu();
                MenuInputHanler();
            }

            else
            {
                for (int i = 0; i < this.taskCards.Count; i++)
                {
                    ShowTaskCard(i);
                }

                taskCards.Remove(taskCards[TaskNumberInputHandler()]);
                
                Console.Clear();
                ShowHeadLine();
                Console.WriteLine("Task succesfully deleted!\n");
                ShowMenu();
                MenuInputHanler();
            }


        }

        private void ShowTasks()
        {
            Console.Clear();
            ShowHeadLine();
            Console.WriteLine("------------------");
            Console.WriteLine("| Your Task List |");
            Console.WriteLine("------------------\n");

            if (this.taskCards.Count == 0)
            {
                Console.Clear();
                ShowHeadLine();
                Console.WriteLine("ERROR : Your Task List is Empty!\n");
            }
            else
            {
                for (int i = 0; i < this.taskCards.Count; i++)
                {
                    ShowTaskCard(i);
                }
            }

            ShowMenu();
            MenuInputHanler();
        }

        private void ShowTaskCard(int taskNumber)
        {
            Console.WriteLine($"-----Task #{taskNumber + 1}------");
            Console.WriteLine($"ID : {taskCards[taskNumber].ID}");
            Console.WriteLine($"Description : {taskCards[taskNumber].Description}");
            Console.WriteLine($"Timing :  {taskCards[taskNumber].StartDate.ToString("dd.MM.yyyy")} -> {taskCards[taskNumber].EndDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Status : {taskCards[taskNumber].Status}");
            Console.WriteLine("------------------\n");
        }

        private DateTime DateInputCheck(string dayInput, string request)
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

        private void TimingInputHandler(out DateTime startDate, out DateTime endDate)
        {         
            Console.Write("Ented Start Date : ");
            startDate = DateInputCheck(Console.ReadLine(), "Ented Start Date : ");

            Console.Write("Enter End Date : ");
            endDate = DateInputCheck(Console.ReadLine(), "Enter End Date : ");

            if (startDate > endDate)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR : END day is less than START day!");
                Console.ResetColor();
                TimingInputHandler(out startDate, out endDate);
            }
        }

        private int TaskNumberInputHandler()
        {
            int task;
            Console.Write("Choose Task : ");

            try
            {
                task = Convert.ToInt32(Convert.ToUInt32(Console.ReadLine()) - 1);

                if (this.taskCards.Count < task)
                { 
                    Console.WriteLine("ERROR : No Task with such number!");
                    return TaskNumberInputHandler();
                }
                else
                    return task;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR : No Task with such number!");
                Console.ResetColor();
                return TaskNumberInputHandler();
            }      
        }
    }
}
