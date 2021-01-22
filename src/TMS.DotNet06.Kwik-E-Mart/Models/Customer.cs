using System;
using System.Collections.Generic;
using System.Text;

namespace Kwik_E_Mart.Models
{
    class Customer
    {
        public string ID { get; set; }
        public int ServiceTime { get; set; }
        public bool inShop { get; set; }
        public bool inQueue { get; set; }
        public bool onService { get; set; }
        public Customer()
        {
            ID = Guid.NewGuid().ToString().ToUpper().Substring(0,6);
            ServiceTime = new Random().Next(0,1000);
            inShop = false;
            inQueue = false;
            onService = false;
        }
    }
}
