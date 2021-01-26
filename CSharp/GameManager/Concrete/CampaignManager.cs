using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void AddCamp(Campaign campaign, Game game, Customer customer)
        {
            Console.WriteLine("Campaign: " + campaign.EntityName + " added for Game: " + game.EntityName + " for Customer: " + customer.FirstName);
        }

        public void DeleteCamn(Campaign campaign, Game game, Customer customer)
        {
            Console.WriteLine("Campaign: " + campaign.EntityName + " updated for Game: " + game.EntityName + " for Customer: " + customer.FirstName);
        }

        public void UpdateCamp(Campaign campaign, Game game, Customer customer)
        {
            Console.WriteLine("Campaign: " + campaign.EntityName + " deleted for Game: " + game.EntityName + " for Customer: " + customer.FirstName);
        }
    }
}
