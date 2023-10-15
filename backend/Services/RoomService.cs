using S11.Common.Dto;
using S11.Common.Enums;
using S11.Data;

namespace S11.Services;

public class RoomService
{
    private readonly Contexto _contexto;

    public RoomService(Contexto contexto)
    {
        _contexto = contexto;
    }

    public  RoomResumeDto GetResume(int nItems = 10)
    {
        var data = _contexto.Rooms.AsQueryable();

        var dto = new RoomResumeDto()
        {
            //TODO mapper
            Data = data.Take(nItems).Select(x => new RoomDto()
            {
                RoomId = x.RoomId,
                RoomNumber = x.RoomNumber,
                Type = x.Type,
                Capacity = x.Capacity
            }),
            Sencilla = data.Count(x => x.Type == RoomType.Sencilla),
            Familiar = data.Count(x => x.Type == RoomType.Familiar),
            Doble = data.Count(x => x.Type == RoomType.Doble),
            TotalRooms = data.Count(),
            TotalTaken = data.Count(x => x.IsTaken == true)
        };

        return dto;
    }
}