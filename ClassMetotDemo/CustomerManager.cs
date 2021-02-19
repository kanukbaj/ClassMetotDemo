using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " +customer.Surname +"Added to Database");
        }
        public void List(Customer[] customers )
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname + "Listed");
            }
            
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + "Deleted");
        }
    }
}
