using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckServices _customerCheckServices;

        public StarbucksCustomerManager(ICustomerCheckServices customerCheckServices)
        {
            _customerCheckServices = customerCheckServices;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckServices.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }

        }


    }
}
