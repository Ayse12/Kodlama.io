using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Abstract
{
    public interface ISalesManager
    {
        void Sell(Customer customer, Game game, Campaign campaign);
        void CancelSale(Customer customer);

    }
}
