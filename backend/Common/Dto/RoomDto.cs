namespace S11.Common.Dto;

public class RoomDto
{
    public int RoomId { get; set; }
    public string RoomNumber { get; set; }
    public string Type { get; set; }
    public int Capacity { get; set; }

    public bool IsTaken { get; set; }
}