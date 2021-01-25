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
        public void OpenShop(Shop shop, CustomerService customerService ,CheckoutService checkoutService)
        {
            shop.isOpen = true;
            AddCheckoutsThreads(shop, customerService, checkoutService);
        }

        public void CloseShop(Shop shop)
        {
            shop.isOpen = false;
        }

        public void AddCheckoutsThreads(Shop shop, CustomerService customerService, CheckoutService checkoutService)
        {
            for (int i = 0; i < shop.QuantityOfCheckouts; i++)
            {
                CheckoutThreads.Add(new Thread(() => checkoutService.ProcessCustomer(shop, customerService, i)));
                CheckoutThreads[i].Start();
            }
            //for (int i = 0; i < shop.QuantityOfCheckouts; i++)
            //{
            //    //CheckoutThreads.Add(new Thread(() => checkoutService.ProcessCustomer(shop, customerService, i)));
            //    CheckoutThreads[i].Start();
            //}
        }
    }
}
