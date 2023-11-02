namespace HotelWiz.Back.Common.Dto.Room;

public class RoomGroupResponseDto
{
    public string Type { get; set; }

    public int TotalFree { get; set; }
    public int TotalTaken { get; set; }
    public int TotalMaintenance { get; set; }
    public int Total { get; set; }

}