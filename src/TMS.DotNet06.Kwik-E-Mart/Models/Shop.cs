using System;
using System.Collections.Generic;
using System.Text;

namespace Kwik_E_Mart.Models
{
    class Shop
    {
        public List<Checkout> Checkouts { get; set; } = new List<Checkout>();
        public int QuantityOfCheckouts { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public bool isOpen { get; set; }
        public Shop(int quantityOfCheckouts)
        {
            for (int i = 0; i < quantityOfCheckouts; i++)
            {
                Checkouts.Add(new Checkout(i));
            }
            QuantityOfCheckouts = quantityOfCheckouts;
            OpeningTime = DateTime.Now;
            ClosingTime = DateTime.Now.AddSeconds(60);
        }

    }
}
