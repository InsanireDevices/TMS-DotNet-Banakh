using System;

namespace TMS.Banakh.Sandbox
{
    abstract class Product
    {

        /// <summary>
        /// Цвет стержня
        /// </summary>
        public int Color { get; set; }


        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Страна происхождения
        /// </summary>
        public string Country { get; set; }

        public void Draw()
        {
            Console.WriteLine("Рисую");
        }

        /// <summary>
        /// Сделать что-то.
        /// </summary>
        public virtual void Do()
        {
            Console.WriteLine("Do somthing.");
        }
    }
}
