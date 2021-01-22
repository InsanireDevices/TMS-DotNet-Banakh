using Kwik_E_Mart.Models;
using System;
using System.Collections.Generic;

namespace Kwik_E_Mart.Sercvices
{
    class CustomerService
    {
        public List<Customer> CustomersList { get; set; } = new List<Customer>();
        public Queue<Customer> CustomersQueue { get; set; } = new Queue<Customer>();
        public void Generator()
        {
            CustomersList.Add(new Customer());
        }
        public void AddToQueue()
        {
            var randomCustomerIndex = new Random().Next(CustomersList.Count);
            CustomersQueue.Enqueue(CustomersList[randomCustomerIndex]);
            CustomersList.Remove(CustomersList[randomCustomerIndex]);
        }
    }
}
