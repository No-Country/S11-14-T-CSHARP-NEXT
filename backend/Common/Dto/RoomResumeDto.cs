namespace S11.Common.Dto;

public class RoomResumeDto
{
    public int Single { get; set; }
    public int Double { get; set; }
    public int Triple { get; set; }
    public int Quad { get; set; }
    public int Queen { get; set; }
    public int King { get; set; }
    public int Total { get; set; }
    public IEnumerable<RoomDto> Data { get; set; }
}