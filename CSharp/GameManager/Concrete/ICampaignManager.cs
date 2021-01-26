using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Concrete
{
     interface ICampaignManager
    {
        void AddCamp(Campaign campaign, Game game, Customer customer);
        void UpdateCamp(Campaign campaign, Game game, Customer customer);
        void DeleteCamn(Campaign campaign, Game game, Customer customer);

    }
}
