using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Bir nesneyi 1 kez Inheritance alabiliriz. Ama birden fazla implementasyon yapabilirsiniz.
    class Program
    {
        //Kalıtım, Miraslar
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="AYŞE" },
                new Student{FirstName="MEHMET"},
                new Person{FirstName="ASLI"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
