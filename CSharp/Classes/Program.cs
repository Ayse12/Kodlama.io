using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            Console.WriteLine("----------------");

            //1. Kullanım
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ayşe";
            customer.LastName = "İlhanlı";
            customer.City = "İstanbul";

            //2. Kullanım
            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Aslıhan",
                LastName = "Evcil",
                City = "İstanbul"
            };

            Console.WriteLine(customer2.FirstName);

        }
    }
}
