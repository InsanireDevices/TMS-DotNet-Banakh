using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.FitnessTracker.Core.Manager
{
    class NotificationManager
    {
        /// <summary>
        /// Method to send status notification to console
        /// </summary>
        /// <param name="notification"></param>
        public static void SendStatusNotification(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{DateTime.Now}] : {notification}");
            Console.ResetColor();
        }
        /// <summary>
        /// Method to send error notification to console
        /// </summary>
        /// <param name="notification"></param>
        public static void SendErrorNotification(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{DateTime.Now}] ERROR : {notification}");
            Console.ResetColor();
        }
    }
}
