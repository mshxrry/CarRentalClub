using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalClub.Models;

    public class ReservationDb : DbContext
    {
        public ReservationDb (DbContextOptions<ReservationDb> options)
            : base(options)
        {
        }

        public DbSet<CarRentalClub.Models.Reservation> Reservation { get; set; }

        public DbSet<CarRentalClub.Models.Location> Location { get; set; }

        public DbSet<CarRentalClub.Models.Rental> Rental { get; set; }

        public DbSet<CarRentalClub.Models.Vehicle> Vehicle { get; set; }

        public DbSet<CarRentalClub.Models.CustomerName> CustomerName { get; set; }
    }
