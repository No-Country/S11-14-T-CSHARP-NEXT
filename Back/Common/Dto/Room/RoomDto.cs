namespace HotelWiz.Back.Common.Dto.Room;

public class RoomDto
{
    public int RoomId { get; set; }
    public string RoomNumber { get; set; }
    public string Type { get; set; }
    public int Capacity { get; set; }

    public string Status { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public decimal Price { get; set; }
}