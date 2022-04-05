using System;
using System.Collections.Generic;

namespace CarRentalClub.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public int CustomerName { get; set; }
        public string ModelNumber { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string GasInTank { get; set; }
        public string OdometerReading { get; set; }

        public ICollection<Rental> Rentals { get; set; }

    }
}