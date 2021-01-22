using System;
using System.Collections.Generic;
using System.Text;

namespace Kwik_E_Mart.Manager
{
    class NotificationManager
    {
        /// <summary>
        /// Method to send status notification to console
        /// </summary>
        /// <param name="notification">Status message</param>
        public static void SendStatusNotification(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{DateTime.Now}] : {notification}");
            Console.ResetColor();
        }
        /// <summary>
        /// Method to send error notification to console
        /// </summary>
        /// <param name="notification">Error message</param>
        public static void SendErrorNotification(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{DateTime.Now}] ERROR : {notification}");
            Console.ResetColor();
        }
        /// <summary>
        /// Method to send exeption notification to console
        /// </summary>
        /// <param name="notification">Exeption message</param>
        public static void SendExeptionNotification(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{DateTime.Now}] Exeption : {notification}");
            Console.ResetColor();
        }
    }
}
