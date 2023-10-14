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
                Name = "A single room to sleep comfortable",
                Type = RoomType.Single
            },
            new Room()
            {
                RoomId = 2,
                Name = "Couple room",
                Type = RoomType.Double
            },
            new Room()
            {
                RoomId = 3,
                Name = "Triple room",
                Type = RoomType.Triple
            },
            new Room()
            {
                RoomId = 4,
                Name = "Quad room",
                Type = RoomType.Quad
            },
            new Room()
            {
                RoomId = 5,
                Name = "Queen room",
                Type = RoomType.Queen
            },
            new Room()
            {
                RoomId = 6,
                Name = "King room",
                Type = RoomType.King
            },

        };

        modelBuilder.Entity<Room>().HasData(_rooms);
    }
}