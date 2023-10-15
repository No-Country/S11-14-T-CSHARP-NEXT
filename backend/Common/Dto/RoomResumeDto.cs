namespace S11.Common.Dto;

public class RoomResumeDto
{
    public int Sencilla { get; set; }
    public int Doble { get; set; }
    public int Familiar { get; set; }
    public int TotalRooms { get; set; }

    public int TotalTaken { get; set; }
    public IEnumerable<RoomDto> Data { get; set; }
}