using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return false;
        }
    }

}
