
using S11.Common.Dto;
using S11.Common.Enums;
using S11.Common.Helpers;

using S11.Data;

namespace S11.Services;

public class RoomService
{
    private readonly Contexto _contexto;

    public RoomService(Contexto contexto)
    {
        _contexto = contexto;
    }


    public async Task<PagedList<RoomDto>> GetRooms(RoomParams roomParams)
    {
        var data = _contexto.Rooms.Select(x => new RoomDto

        {
            RoomId = x.RoomId,
            RoomNumber = x.RoomNumber,
            Type = x.Type,
            Capacity = x.Capacity,
            Status = x.Status,
            ImageUrl = x.ImageUrl,
            Price = x.Price,
            Description = x.Description,

        }).AsQueryable();
        var rooms = await PagedList<RoomDto>.ToPageList(data, roomParams.PageNumber, roomParams.PageSize);
        
        
        return rooms;
    }


    public RoomDto? GetRoomById(int id)
    {
        var room = _contexto.Rooms.FirstOrDefault(x => x.RoomId == id);


        
        
        return room != null ? new RoomDto
        {
            RoomId = room.RoomId,
            RoomNumber = room.RoomNumber,
            Type = room.Type,
            Capacity = room.Capacity,
            Status = room.Status,
            ImageUrl = room.ImageUrl,
            Price = room.Price,
            Description = room.Description,

        } : null;

    }

    public RoomResumeDto GetResume()
    {
        var data = _contexto.Rooms.AsQueryable();

        var dto = new RoomResumeDto()
        {
            Data = data.Select(x => new RoomDto()
            {
                RoomId = x.RoomId,
                RoomNumber = x.RoomNumber,
                Type = x.Type,
                Capacity = x.Capacity,
                Status = x.Status,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
                Description = x.Description
            }),
            Types = data.GroupBy(x => x.Type).Select(x => new RoomGroupResponseDto
            {
                Type = x.Key,
                TotalFree = x.Count(x => x.Status == RoomStatus.Libre),
                TotalTaken = x.Count(x => x.Status == RoomStatus.Reservada),
                TotalMaintenance = x.Count(x => x.Status == RoomStatus.Mantenimiento),
                Total = x.Count()
            }),

            TotalRooms = data.Count(),
            TotalTaken = data.Count(x => x.Status == RoomStatus.Reservada),
            TotalFree = data.Count(x => x.Status == RoomStatus.Libre),
            TotalMaintenance = data.Count(x => x.Status == RoomStatus.Mantenimiento),
            Sencilla = data.Count(x => x.Type == RoomType.Sencilla),
            Doble = data.Count(x => x.Type == RoomType.Doble),
            Familiar = data.Count(x => x.Type == RoomType.Familiar),
            Triple = data.Count(x => x.Type == RoomType.Triple),
            King = data.Count(x => x.Type == RoomType.King),
            Presidencial = data.Count(x => x.Type == RoomType.Presidencial),
            Mini = data.Count(x => x.Type == RoomType.Mini),
        };

        return dto;
    }
}