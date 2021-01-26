using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string TCNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime YearofBirth { get; set; }
    }

}
