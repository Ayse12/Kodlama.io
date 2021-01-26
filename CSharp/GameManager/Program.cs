using GameManager.Abstract;
using GameManager.Adapter;
using GameManager.Concrete;
using GameManager.Entities;
using System;

namespace GameManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICustomer customer = new Student();
            Customer customer = new Customer() { Id = 1, FirstName = "Ayşe", LastName = "İlhanlı", YearofBirth= new DateTime(1998, 7, 3)};
            ICustomerService signUpManager = new SignUpManager(new MernisServiceAdapter());
            signUpManager.Save(new Customer { Id = 2, FirstName = "Ayşegül", LastName = "İlhanlı", YearofBirth = new DateTime(1998, 7, 3) });
            signUpManager.Save(customer);

            ICampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign() { EntityName = "GAME25" };
            Game game1 = new Game() { EntityName = "CS:GO" };

            campaignManager.AddCamp(campaign1, game1, customer);

            ISalesManager salesManager = new SalesManager();
            salesManager.Sell(customer, game1, campaign1);

            //BaseCustomerManager customerManager = new NeroCustomerManager();
            //customerManager.Save(new Customer { DateOfBirth = new DateTime(1998, 7, 3), FirstName = "Ayşe", LastName = "İlhanlı", NationalityId = "123456" });
            //Console.ReadLine();
        }
    }
}
