using S11.Common.Dto;
using S11.Common.Dto.Reservation;
using S11.Data.Models;
using S11.Services;

namespace S11.Common.Mappers
{
    public static class RoomMappers
    {
        public static List<RoomDto> RoomToDto(this IEnumerable<Room> rooms)
        {

            var dots = new List<RoomDto>();
            foreach (Room item in rooms)
            {
                dots.Add(item.RoomToDto());
            }
            return dots;
        }


        public static RoomDto RoomToDto(this Room room)
        {
            return new RoomDto
            {
                Capacity = room.Capacity,
                Description = room.Description,
                ImageUrl = room.ImageUrl,
                Price = room.Price,
                RoomId = room.RoomId,
                RoomNumber = room.RoomNumber,
                Status = room.Status,
                Type = room.Type
            };
        }

        public static RoomNameDto RoomToRoomNameDto(this Room room)
        {
            return new RoomNameDto
            {
                RoomNumber = room.RoomNumber,
            };
        }
    }

    public class RoomNameDto
    {
        public string RoomNumber { get; set; }
    }
}
