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
            var kwikEMartService = new ShopService();
            var kwikCheckoutService = new CheckoutService();

            var kwikEMart = new Shop(5);

            kwikEMartService.OpenShop(kwikEMart, customerService ,kwikCheckoutService);

            customerService.Generator();
            customerService.Generator();
            customerService.Generator();
            customerService.Generator();
            customerService.Generator();
            customerService.Generator();
            customerService.AddToQueue();
            customerService.AddToQueue();
            customerService.AddToQueue();
            customerService.AddToQueue();
            customerService.AddToQueue();

            //kwikCheckoutService.TakeCustomerFromQueue(customerService);

            Console.ReadKey();
        }
    }
}
