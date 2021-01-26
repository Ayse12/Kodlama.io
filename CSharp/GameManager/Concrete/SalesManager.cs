using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Concrete
{
    public class SalesManager : ISalesManager
    {

        public void CancelSale(Customer customer)
        {
            Console.WriteLine("Sales Cancelled for customer: " + customer.FirstName);
        }

        public void Sell(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine("Sold to customer: " + customer.FirstName );
        }


    }
}
