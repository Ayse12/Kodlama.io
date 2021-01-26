using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Adapter
{
    class MernisServiceAdapter : BaseCustomerManager
    {
        public  bool CustomerCheckForReal(Customer customer)
        {
            Console.WriteLine("Search by name and lastname in anaother system");
            return true;

        }
    }
}
