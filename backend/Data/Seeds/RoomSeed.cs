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
                State = RoomState.Reservada,
                Price = 2000,
                Description = "A single room",
                ImageUrl = "https://www.collinsdictionary.com/images/full/singleroom_713511961_1000.jpg"
            },
            new Room()
            {
                RoomId = 2,
                RoomNumber = "A-102",
                Type = RoomType.Doble,
                Capacity = 2,
                State = RoomState.Libre,
                Price = 3000,
                Description = "A Double room",
                ImageUrl = "https://www.hotel7dublin.com/wp-content/uploads/Hotel-7-double-bedroom.jpg"
            },
            new Room()
            {
                RoomId = 3,
                RoomNumber = "A-103",
                Type = RoomType.Familiar,
                Capacity = 7,
                State = RoomState.Mantenimiento,
                Price = 4000,
                Description = "A familiar room",
                ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200"
            },
            

        };

        modelBuilder.Entity<Room>().HasData(_rooms);
    }
}