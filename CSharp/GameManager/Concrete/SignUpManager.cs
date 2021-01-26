using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Concrete
{
    public class SignUpManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;

        public SignUpManager(BaseCustomerManager baseCheckService)
        {

            _customerCheckService = baseCheckService;
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted!!");
        }

        public void Save(Customer customer)
        {
            Console.WriteLine("Customer Save!!");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer Update!!");
        }
    }
}
