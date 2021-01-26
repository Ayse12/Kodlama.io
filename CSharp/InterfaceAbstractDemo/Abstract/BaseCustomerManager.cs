using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        //Ezmek
        public virtual void Save(Customer customer)
        {
            Console.WriteLine( "Saved to db  :  "+customer.FirstName);
        }
    }
}
