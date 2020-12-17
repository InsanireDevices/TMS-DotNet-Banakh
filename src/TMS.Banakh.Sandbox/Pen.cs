using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.Banakh.Sandbox
{
    /// <summary>
    ///Ручка. 
    /// </summary>
    class Pen : Product
    {
        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        public Pen()
        {
            Console.WriteLine("Я родился!!");
        }

        /// <summary>
        /// Конструктор с параметром цвета.
        /// </summary>
        /// <param name="color">Цвет.</param>
        public Pen(int color)
        {
            Color = color;
            Console.WriteLine("Я родился цветным!!");
        }
    }
}
