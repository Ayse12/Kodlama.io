using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Abstract
{
    public abstract class BaseCustomerManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            return true;
          }

    }
}
