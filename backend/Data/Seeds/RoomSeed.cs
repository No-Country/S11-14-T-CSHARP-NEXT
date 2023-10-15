using Microsoft.EntityFrameworkCore;
using S11.Common.Enums;
using S11.Data.Models;

namespace S11.Data.Seeds;

public class RoomSeed
{
    private static List<Room> _rooms;
    
    public static void Seed(ModelBuilder modelBuilder)
    {
        _rooms = new List<Room> {
            new Room()
            {
                RoomId = 1,
                RoomNumber = "A-101",
                Type = RoomType.Sencilla,
                Capacity = 1,
                IsTaken = true
            },
            new Room()
            {
                RoomId = 2,
                RoomNumber = "A-102",
                Type = RoomType.Doble,
                Capacity = 2,
                IsTaken = false
            },
            new Room()
            {
                RoomId = 3,
                RoomNumber = "A-103",
                Type = RoomType.Familiar,
                Capacity = 3,
                IsTaken = true
            },
            

        };

        modelBuilder.Entity<Room>().HasData(_rooms);
    }
}