using System;
using System.Collections.Generic;

namespace CarRentalClub.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public int Address { get; set; }
        public string City { get; set; }

        public string State { get; set; }


        public ICollection<Location> Locations { get; set; }

    }
}
