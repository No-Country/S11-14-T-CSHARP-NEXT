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

    public async Task<RoomResumeDto> GetResume(int nItems = 10)
    {
        var data = _contexto.Rooms.AsQueryable();

        var dto = new RoomResumeDto()
        {
            //TODO mapper
            Data = data.Take(nItems).Select(x => new RoomDto()
            {
                RoomId = x.RoomId,
                Name = x.Name,
                Type = x.Type,
              
            }),
            Single = data.Count(x => x.Type == RoomType.Single),
            Double = data.Count(x => x.Type == RoomType.Double),
            Triple = data.Count(x => x.Type == RoomType.Triple),
            Quad = data.Count(x => x.Type == RoomType.Quad),
            Queen = data.Count(x => x.Type == RoomType.Queen),
            King = data.Count(x => x.Type == RoomType.King),
            Total = data.Count()
        };

        return dto;
    }
}