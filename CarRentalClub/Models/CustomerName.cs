using System;
using System.Collections.Generic;

namespace CarRentalClub.Models
{
    public class CustomerName
    {
        public int CustomerNameId { get; set; }

        public int Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public ICollection<CustomerName> CustomerNames { get; set; }
    }
}
