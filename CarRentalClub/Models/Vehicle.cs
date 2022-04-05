using System;
using System.Collections.Generic;

namespace CarRentalClub.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }

        public int Type { get; set; }
        public string ModelNumber { get; set; }
        public int Transmission { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
