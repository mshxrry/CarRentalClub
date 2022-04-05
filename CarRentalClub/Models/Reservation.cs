using System;
using System.Collections.Generic;

namespace CarRentalClub.Models
{
    public class Reservation
    {

        public int ReservationId { get; set; }
        public int CustomerName { get; set; }
        public string ModelNumber { get; set; }
        public string LocationAddress { get; set; }
        public DateTime PickUpTime { get; set; }
        public DateTime ReturnDate { get; set; }


        public ICollection<Reservation> Reservations { get; set; }

    }
}
