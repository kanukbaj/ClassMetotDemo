using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Mike",
                Surname = "Sobbarrow",
                IdentityNumber = "12345678901"
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Burak",
                Surname = "Gaytan",
                IdentityNumber = "9876543212"
            };
            Customer[] customerListe = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer1);

            customerManager.Add(customer2);
            customerManager.Delete(customer2);

            customerManager.List(customerListe);

            Console.ReadKey();
        }
    }
}
