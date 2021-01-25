using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntarfacesIntro();

            //Bir interface hiçbir zaman newlenemez.
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3] 
            {
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void IntarfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer { Id = 1, FirstName = "Ayşe", LastName = "İlhanlı", Address = "Diyarbakır" };
            personManager.Add(customer);

            Student student = new Student { Id = 2, FirstName = "Aslı", LastName = "Evcil", Departmant = "Computer Sciences" };
            personManager.Add(student);
        }
    }
    //Soyut nesnelerdirr. 
    interface IPerson
    {
        //Metodun imzası olur. 
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        //İmplement edildi. IPerson'ı
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        //İmplement edildi. IPerson'ı
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        //İmplement edildi. IPerson'ı
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
