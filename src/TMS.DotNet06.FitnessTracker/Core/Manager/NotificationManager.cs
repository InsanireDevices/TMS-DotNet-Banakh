using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.FitnessTracker.Core.Manager
{
    class NotificationManager
    {
        public void SendStatusNotification(string notification, DateTime dateTime)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{dateTime}] : {notification}");
            Console.ResetColor();
        }

        public void SendErrorNotification(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{DateTime.Now}] ERROR : {notification}");
            Console.ResetColor();
        }
    }
}
