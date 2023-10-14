using System.ComponentModel.DataAnnotations;

namespace S11.Data.Models;

public class Room
{
    [Key]
    public int RoomId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    
    //TODO: Add Reserva FK
}