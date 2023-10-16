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

    public RoomResumeDto GetResume()
    {
        var data = _contexto.Rooms.AsQueryable();

        var dto = new RoomResumeDto()
        {
            //TODO mapper
            Data = data.Select(x => new RoomDto()
            {
                RoomId = x.RoomId,
                RoomNumber = x.RoomNumber,
                Type = x.Type,
                Capacity = x.Capacity
            }),
            Types = data.GroupBy(x => x.Type).Select(x => new RoomGroupResponseDto
            {
                Type = x.Key,
                TotalFree = x.Count(x => !x.IsTaken), 
                TotalTaken = x.Count(x => x.IsTaken),
                Total = x.Count()
            }),
            
            TotalRooms = data.Count(),
            TotalTaken = data.Count(x => x.IsTaken == true),
            TotalFree = data.Count(x => x.IsTaken != true)
        };

        return dto;
    }
}