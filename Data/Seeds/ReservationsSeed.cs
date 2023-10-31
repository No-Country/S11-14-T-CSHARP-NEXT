using Microsoft.EntityFrameworkCore;
using S11.Data.Models;
using static S11.Common.Enums.PeopleIdentity;
using static S11.Common.Enums.Reservations.Reservations;

namespace S11.Data.Seeds
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
                    ReservationConsecutive = $"W{DateTime.Now.ToString("yymmdd")}1",
                    GuestName = "Guest1",
                    GuestEmail = "Guest1@example.com",
                    GuestDocumentType = IdentityDocumentType.Passport,
                    GuestDocumentNumber = "1",
                    Status = ReservationStatus.OnHold,
                    CheckInExpectedDate = new DateTime(2023,11,5),
                    CheckOutExpectedDate = new DateTime(2023,11,8),
    },
                new Reservation()
                {
                    ReservationId = 2,
                    ReservationConsecutive = $"W{DateTime.Now.ToString("yymmdd")}2",
                    GuestName = "Guest2",
                    GuestEmail = "Guest2@example.com",
                    GuestDocumentType = IdentityDocumentType.Passport,
                    GuestDocumentNumber = "2",
                    Status = ReservationStatus.OnHold,
                    CheckInExpectedDate = new DateTime(2023,11,8),
                    CheckOutExpectedDate = new DateTime(2023,11,9),
                },
                new Reservation()
                {
                    ReservationId = 3,
                    ReservationConsecutive = $"W{DateTime.Now.ToString("yymmdd")}3",
                    GuestName = "Guest3",
                    GuestEmail = "Guest3@example.com",
                    GuestDocumentType = IdentityDocumentType.Passport,
                    GuestDocumentNumber = "3",
                    Status = ReservationStatus.OnHold,
                    CheckInExpectedDate = new DateTime(2023,11,10),
                    CheckOutExpectedDate = new DateTime(2023,11,12),
                },
            };

            modelBuilder.Entity<Reservation>().HasData(_reservations);
        }
    }
}