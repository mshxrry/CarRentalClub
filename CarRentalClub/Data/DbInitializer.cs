using CarRentalClub.Models;
using System;
using System.Linq;

namespace CarRentalClub.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Reservation context)
        {
            context.DataBase.EnsureCreated();

            // Look for any customers.
            if (context.CustomerName.Any())
            {
                return;   // DB has been seeded
            }

            var students = new CustomerName[]
            {
            new CustomerName{Name="Hasan",Address="21 Tait st",PhoneNumber=01982682573},
            new CustomerName{Name="Luke",Address="24 Mount St",PhoneNumber=078263813},
            new CustomerName{Name="Arturo",Address="233 Eden Land",PhoneNumber=073546721},
            new CustomerName{Name="Gytis",Address="76 City AVe",PhoneNumber=0927384722},
            new CustomerName{Name="Yan",Address="52 Pass Road",PhoneNumber=026458112},
            new CustomerName{Name="Peggy",Address="90 New Park",PhoneNumber=053217389},


            };
            foreach (CustomerName c in CustomerNames)
            {
                context.CustomerName.Add(c);
            }
            context.SaveChanges();

            var Reservations = new Reservation[]
            {
            new Reservation{CustomerName="Hasan",ModelNumber=09272,LocationAddress="21 Tait st",PickUpTime = TimeSpan.Parse(8:21),ReturnDate = TimeSpan.FromDays(09/01/22)},
            new Reservation{CustomerName="Luke",ModelNumber=82911,LocationAddress="24 Mount St",PickUpTime = TimeSpan.Parse(9:42),ReturnDate = TimeSpan.FromDays(11/02/22)},
            new Reservation{CustomerName="Arturo",ModelNumber=72232,LocationAddress="233 Eden land",PickUpTime = TimeSpan.Parse(11:23),ReturnDate = TimeSpan.FromDays(25/01/22)},
            new Reservation{CustomerName="Gytis",ModelNumber=89214,LocationAddress="76 City AVe",PickUpTime = TimeSpan.Parse(6:45),ReturnDate = TimeSpan.FromDays(09/03/22)},
            new Reservation{CustomerName="Yan",ModelNumber=92637,LocationAddress="52 Pass Road",PickUpTime = TimeSpan.Parse(7:28),ReturnDate = TimeSpan.FromDays(07/01/22)},
            new Reservation{CustomerName="Peggy",ModelNumber=37892,LocationAddress="90 New Park",PickUpTime = TimeSpan.Parse(3:50),ReturnDate = TimeSpan.FromDays(27/03/22)},
           
            };
            foreach (Reservation R in Reservations)
            {
                context.Courses.Add(R);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Location{Address="21 Tait st",City="Auckland",State="NorthIsland"},
            new Location{Address="24 Mount St",City="Auckland",Grade=Grade.C},
            new Location{Address="233 Eden Land",City="Auckland",=4041,Grade=Grade.B},
            new Location{Address="76 City AVe",City="Auckland",Grade=Grade.B},
            new Location{Address="52 Pass Road",City="Auckland",Grade=Grade.F},
            new Location{Address="90 New Park",City="Auckland",Grade=Grade.F},
        
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}