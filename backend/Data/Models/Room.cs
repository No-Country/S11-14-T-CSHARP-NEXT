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
    public string State { get; set; }

    public string ImageUrl { get; set; }

    public string Description { get; set; }

    //TODO: Add Reserva FK
}