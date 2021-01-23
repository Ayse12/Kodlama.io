using System;

//Constructors - Bir classı new lediğimiz zaman çalışan bloktur
//Metod gibidirler. Metot mantığıtla çalışırlar
namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Kullanım
            Customer customer1 = new Customer() { Id = 1, FirstName = "Ahmet", LastName = "Yıldırım", City = "NYU" };
            //2.Kullanım
            Customer customer2 = new Customer(2, "Ayşe", "İlhanlı", "İstanbul");

            Console.WriteLine(customer1.FirstName);

        }
    }
    class Customer
    {
        //Default constructor
        //Kod yazdıysan bu blok arasındakı kod çalışır yok ise arka plan kodu çalışır.
        //ctor tab tab
        public Customer(int id, string firstName, string lastName, string city)
        {
            //2. Kullanım için
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public Customer()
        {
            //1.Kullanım için
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
