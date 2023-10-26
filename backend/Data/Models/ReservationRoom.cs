using System.ComponentModel.DataAnnotations;

namespace S11.Data.Models
{
    public class ReservationRoom
    {
        [Key]
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public string TypeRoom { get; set; }
     

        public Reservation Reservation { get; set; }
     
    }
}
