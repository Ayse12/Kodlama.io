using System;

namespace GameManager2
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1998,
                FirstName = "Ayşe",
                LastName = "İlhanlı",
                IdentityNumber = 12345
            });
            Console.WriteLine("Hello World!");
        }
    }
}
