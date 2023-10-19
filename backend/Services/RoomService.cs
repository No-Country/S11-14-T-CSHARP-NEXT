using Microsoft.AspNetCore.Http.HttpResults;
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

    public IEnumerable<RoomDto> GetRooms()
    {
        var data = _contexto.Rooms.ToList().Select(x => new RoomDto
        {
            RoomId = x.RoomId,
            RoomNumber = x.RoomNumber,
            Type = x.Type,
            Capacity = x.Capacity,
            State = x.State,
            ImageUrl = x.ImageUrl,
            Price = x.Price,
            Description = x.Description,
            
        });

        return data;
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
            State = room.State,
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
                State = x.State,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
                Description = x.Description
            }),
            Types = data.GroupBy(x => x.Type).Select(x => new RoomGroupResponseDto
            {
                Type = x.Key,
                TotalFree = x.Count(x => x.State == RoomState.Libre),
                TotalTaken = x.Count(x => x.State == RoomState.Reservada),
                TotalMaintenance = x.Count(x => x.State == RoomState.Mantenimiento),
                Total = x.Count()
            }),

            TotalRooms = data.Count(),
            TotalTaken = data.Count(x => x.State == RoomState.Reservada),
            TotalFree = data.Count(x => x.State == RoomState.Libre),
            TotalMaintenance = data.Count(x => x.State == RoomState.Mantenimiento)
        };

        return dto;
    }
}