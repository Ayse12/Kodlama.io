using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ,decimal,float,enum,boolean,value types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayı 1 : " + sayi1); //20

            //arrays,class,interface....reference types
            int[] sayilar1 = new int[] { 1, 2, 3, 4 };
            int[] sayilar2 = new int[] { 10, 20, 30, 40 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayılar1[0] = " + sayilar1[0]);

            Console.WriteLine("---------ClassRef----------");

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Ayşe";

            person2 = person1;

            person1.FirstName = "Aslı";
            Console.WriteLine(person2.FirstName);

            Customer cstmr = new Customer();
            cstmr.FirstName = "Salih";
            Console.WriteLine(cstmr.FirstName);
            cstmr.CreditCardNumber = "12345678950";

            Employee emp = new Employee();
            emp.FirstName = "Acar";

            Person person3 = cstmr;
            cstmr.FirstName = "Ahmet";// Buradda ismi değiştirdik. Adresteki veri değiştirildi.
            Console.WriteLine(person3.FirstName);

            Console.WriteLine("----------Boxing-------------");
            Person person4 = cstmr;
            cstmr.FirstName = "Fatma";
            Console.WriteLine(((Customer)person4).CreditCardNumber);

            Console.WriteLine("------PersonManager------");
            PersonManager prsnManager = new PersonManager();
            prsnManager.Add(emp);

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //Base class : Person = Ana Class
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        //İstenildiği zaman müşteri ve çalışanlarla çalışmak için
        //Base'i parametre verdiğim için diğer classlarda cağrılır.
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
