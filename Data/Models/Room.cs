using System.ComponentModel.DataAnnotations;

namespace S11.Data.Models;

public class Room
{
    [Key]
    public int RoomId { get; set; }
    public string RoomNumber { get; set; }
    public string Type { get; set; }
    public int Capacity { get; set; }
    public Decimal Price { get; set; }
    public string Status { get; set; }

    public string ImageUrl { get; set; }

    public string Description { get; set; }
    public ICollection<ReservationRoom> Reservations { get; set; } // Propiedad de navegación
    //TODO: Add Reserva FK
}