using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.FitnessTracker.Core.Manager
{
    class NotificationManager
    {
        public static void SendStatusNotification(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{DateTime.Now}] : {notification}");
            Console.ResetColor();
        }

        public static void SendErrorNotification(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{DateTime.Now}] ERROR : {notification}");
            Console.ResetColor();
        }
    }
}
