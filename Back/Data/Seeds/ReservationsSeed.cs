using HotelWiz.Back.Data.Models;
using Microsoft.EntityFrameworkCore;
using static HotelWiz.Back.Common.Enums.PeopleIdentity;
using static HotelWiz.Back.Common.Enums.Reservations;

namespace HotelWiz.Back.Data.Seeds
{
    public static class ReservationsSeed
    {
        private static List<Reservation> _reservations;

        public static void Seed(ModelBuilder modelBuilder)
        {
            _reservations = new List<Reservation> {
                new Reservation()
                {
                    ReservationId = 1,
                    ReservationConsecutive = $"28455672-B",
                    GuestName = "Manuel Zapata",
                    GuestEmail = "mzapata@favi.com",
                     GuestPhoneNumber = "573005447864",
                    GuestDocumentType = IdentityDocumentType.Passport,
                    GuestDocumentNumber = "1",
                    Status = ReservationStatus.OnHold,
                    CheckInExpectedDate = new DateTime(2023,11,2),
                    CheckOutExpectedDate = new DateTime(2023,11,3),
                    NumberOfGuests = 1,
    },
                new Reservation()
                {
                    ReservationId = 2,
                    ReservationConsecutive = $"15258798-B",
                    GuestName = "Carla Nichols",
                    GuestEmail = "KarlaNichols@live.com",
                    GuestPhoneNumber = "528564545447",
                    GuestDocumentType = IdentityDocumentType.Passport,
                    GuestDocumentNumber = "2",
                    Status = ReservationStatus.OnHold,
                    CheckInExpectedDate = new DateTime(2023,11,8),
                    CheckOutExpectedDate = new DateTime(2023,11,9),
                    NumberOfGuests = 1,
                },
                new Reservation()
                {
                    ReservationId = 3,
                    ReservationConsecutive =  $"4585458-B",
                    GuestName = "Joshua Niels",
                    GuestEmail = "niels.j@orabl.com",
                     GuestPhoneNumber = "618545547554",
                    GuestDocumentType = IdentityDocumentType.Passport,
                    GuestDocumentNumber = "3",
                    Status = ReservationStatus.OnHold,
                    CheckInExpectedDate = new DateTime(2023,11,10),
                    CheckOutExpectedDate = new DateTime(2023,11,12),
                    NumberOfGuests = 1,
                },
            };

            modelBuilder.Entity<Reservation>().HasData(_reservations);
        }
    }
}