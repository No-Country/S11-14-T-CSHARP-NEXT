namespace HotelWiz.Back.Common.Dto.Room;

public class RoomResumeDto
{
    public int Sencilla { get; set; }
    public int Doble { get; set; }
    public int Familiar { get; set; }
    public int Triple { get; set; }
    public int Mini { get; set; }
    public int Presidencial { get; set; }
    public int King { get; set; }
    public int TotalRooms { get; set; }

    public int TotalTaken { get; set; }
    public int TotalFree { get; set; }

    public int TotalMaintenance { get; set; }
    public IEnumerable<RoomDto> Data { get; set; }
    public IEnumerable<RoomGroupResponseDto> Types { get; set; }

}