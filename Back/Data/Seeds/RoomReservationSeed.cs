using HotelWiz.Back.Common.Enums;
using HotelWiz.Back.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelWiz.Back.Data.Seeds
{
    public class RoomReservationSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var _reservationRooms = new List<ReservationRoom>
    {
        new ReservationRoom
        {
            Id = 1,
            ReservationId = 1,
            TypeRoom = RoomType.Sencilla

        },
        new ReservationRoom
        {
             Id = 2,
            ReservationId = 2,
            TypeRoom = RoomType.Mini
        },
         new ReservationRoom
        {
             Id = 3,
            ReservationId = 3,
            TypeRoom = RoomType.Triple
        },


    };

            modelBuilder.Entity<ReservationRoom>().HasData(_reservationRooms);
        }
    }
}
