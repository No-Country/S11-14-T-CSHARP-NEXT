using System.ComponentModel.DataAnnotations;

namespace HotelWiz.Back.Data.Models
{
    public class ReservationRoom
    {
        [Key]
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public string TypeRoom { get; set; }

        public int RoomId { get; set; }
        public string? RoomName { get; set; }

        public Reservation Reservation { get; set; }

    }
}
