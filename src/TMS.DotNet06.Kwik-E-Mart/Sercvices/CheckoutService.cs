using Kwik_E_Mart.Models;
using System;
using System.Threading;

namespace Kwik_E_Mart.Sercvices
{
    class CheckoutService
    {
        static object locker = new object();
        public void ProcessCustomer(Shop shop, CustomerService customerService, int i)
        {
            while (shop.isOpen || customerService.CustomersQueue.Count != 0)
            {
                Console.WriteLine($"Thread : {i}");
                lock (locker)
                {
                    if (customerService.CustomersQueue.Count != 0)
                    {
                        var customerInProcess = TakeCustomerFromQueue(customerService);
                        Thread.Sleep(customerInProcess.ServiceTime);
                        Console.WriteLine("Customer PROCESSED!!!!!!!!!!!!");
                    }
                }
            }

        }

        public Customer TakeCustomerFromQueue(CustomerService customerService)
        {
            return customerService.CustomersQueue.Dequeue();
        }
    }
}
