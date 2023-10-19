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
                Status = RoomStatus.Reservada,
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
                Status = RoomStatus.Libre,
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
                Status = RoomStatus.Mantenimiento,
                Price = 4000,
                Description = "A familiar room",
                ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200"
            },
            new Room()
            {
                RoomId = 4,
                RoomNumber = "A-104",
                Type = RoomType.King,
                Capacity = 5,
                Status = RoomStatus.Mantenimiento,
                Price = 5000,
                Description = "A king room",
                ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200"
            },
            new Room()
            {
                RoomId = 5,
                RoomNumber = "A-105",
                Type = RoomType.Master,
                Capacity = 9,
                Status = RoomStatus.Mantenimiento,
                Price = 10000,
                Description = "A Master room",
                ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200"
            },
            new Room()
            {
                RoomId = 6,
                RoomNumber = "A-106",
                Type = RoomType.Mini,
                Capacity = 1,
                Status = RoomStatus.Reservada,
                Price = 1500,
                Description = "A Mini room",
                ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200"
            },
            new Room()
            {
                RoomId = 7,
                RoomNumber = "A-107",
                Type = RoomType.Triple,
                Capacity = 3,
                Status = RoomStatus.Reservada,
                Price = 7500,
                Description = "A Triple room",
                ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200"
            },
            new Room()
            {
                RoomId = 8,
                RoomNumber = "A-108",
                Type = RoomType.Presidencial,
                Capacity = 4,
                Status = RoomStatus.Libre,
                Price = 30000,
                Description = "A Presidencial room",
                ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200"
            },
            

        };

        modelBuilder.Entity<Room>().HasData(_rooms);
    }
}