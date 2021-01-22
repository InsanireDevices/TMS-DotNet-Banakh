using System;
using System.Collections.Generic;
using System.Text;

namespace Kwik_E_Mart.Models
{
    class Checkout
    {
        public int CheckoutNumber { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public bool isFree { get; set; }
        public bool isOpen { get; set; }
        public Checkout(int checkoutNumber)
        {
            var rnd = new Random();
            CheckoutNumber = checkoutNumber;
            OpeningTime = DateTime.Now;
            ClosingTime = OpeningTime.AddSeconds(rnd.Next(5,10));
            isFree = true;
            isOpen = true;
        }
    }
}
