using Kwik_E_Mart.Models;
using Kwik_E_Mart.Sercvices;
using System;

namespace KwikEMart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Kwik-E-Mart!");
            var customerService = new CustomerService();
            
            var kwikEMart = new Shop(5);
            foreach (var item in kwikEMart.Checkouts)
            {
                Console.WriteLine(item.CheckoutNumber);
            }

            var kwikEMartService = new ShopService();

            kwikEMartService.OpenShop(kwikEMart);

            customerService.Generator();
            customerService.AddToQueue();

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
