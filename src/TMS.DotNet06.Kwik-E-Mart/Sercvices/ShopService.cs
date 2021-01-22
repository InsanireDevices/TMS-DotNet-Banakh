using Kwik_E_Mart.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Kwik_E_Mart.Sercvices
{
    class ShopService
    {
        
        public List<Thread> CheckoutThreads { get; set; } = new List<Thread>();

        public void OpenShop(Shop shop)
        {
            shop.isOpen = true;
            AddCheckoutsThreads(shop);
        }

        public void CloseShop(Shop shop)
        {
            shop.isOpen = false;
        }

        public void AddCheckoutsThreads(Shop shop)
        {
            for (int i = 0; i < shop.Checkouts.Count; i++)
            {
                CheckoutThreads.Add(new Thread())
            }
        }
    }
}
