using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.TaskList
{
    class TaskCard
    {
        public string ID;
        public string Description;
        public DateTime StartDate;
        public DateTime EndDate;
        public string Status;

        public enum StatusList
        {
            ToDo,
            InProgress,
            Done
        }

        public TaskCard(string description, DateTime startDate, DateTime endDate)
        {
            ID = IdGenerator();
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Status = Enum.Parse<StatusList>("ToDo").ToString();
        }

        private static string IdGenerator()
        {
            string id = null;
            char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            Random random = new Random();

            id = $"{symbols[random.Next(15)]}{symbols[random.Next(15)]}{symbols[random.Next(15)]}{symbols[random.Next(15)]}{symbols[random.Next(15)]}";

            return id;
        }
    }
}
