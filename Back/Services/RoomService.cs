using HotelWiz.Back.Common.Dto.Room;
using HotelWiz.Back.Common.Enums;
using HotelWiz.Back.Common.Helpers;
using HotelWiz.Back.Data;
using HotelWiz.Back.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelWiz.Back.Services;

public class RoomService
{
    private readonly Contexto _contexto;

    public RoomService(Contexto contexto)
    {
        _contexto = contexto;
    }

    public RoomDto AddRoom(RoomDto dto)
    {
        var newRoom = new Room
        {
            RoomNumber = dto.RoomNumber,
            Type = dto.Type,
            Capacity = dto.Capacity,
            Description = dto.Description,
            ImageUrl = dto.ImageUrl,
            Price = dto.Price,
            Status = dto.Status,

        };

        _contexto.Rooms.Add(newRoom);
        _contexto.SaveChanges();

        return dto;
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

        data = roomParams.OrderBy switch
        {
            "price" => data.OrderBy(room => room.Price),
            "priceDesc" => data.OrderByDescending(room => room.Price),
            "type" => data.OrderBy(room => room.Type),
            "typeDesc" => data.OrderByDescending(room => room.Type),
            "status" => data.OrderBy(room => room.Status),
            "statusDesc" => data.OrderByDescending(room => room.Status),
            _ => data.OrderBy(room => room.RoomNumber)
        };

        var rooms = await PagedList<RoomDto>.ToPageList(data, roomParams.PageNumber, roomParams.PageSize);


        return rooms;
    }

    public RoomDto? GetRoomById(int id)
    {
        var room = _contexto.Rooms.FirstOrDefault(x => x.RoomId == id);



        return room != null
            ? new RoomDto
            {
                RoomId = room.RoomId,
                RoomNumber = room.RoomNumber,
                Type = room.Type,
                Capacity = room.Capacity,
                Status = room.Status,
                ImageUrl = room.ImageUrl,
                Price = room.Price,
                Description = room.Description,
            }
            : null;



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

    //TODO too slow
    public RoomDto? UpdateRoom(RoomDto dto)
    {
        var room = _contexto.Rooms.FirstOrDefault(x => x.RoomId == dto.RoomId);

        if (room != null)
        {
            // Realizar actualizaciones de la habitación
            room.RoomNumber = dto.RoomNumber;
            room.Status = dto.Status;
            room.ImageUrl = dto.ImageUrl;
            room.Price = dto.Price;
            room.Description = dto.Description;
            room.Capacity = dto.Capacity;

            using (var transaction = _contexto.Database.BeginTransaction())
            {
                try
                {
                    _contexto.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Manejo de la excepción o posibles errores.
                    transaction.Rollback();
                    // Aquí podrías hacer un log de la excepción o manejar el error de alguna manera.
                    return null;
                }
            }

            return dto;
        }

        return null; // La habitación no se encontró en la base de datos.
    }

    //TODO too slow
    public async Task<RoomResumeDto> GetResume()
    {
        var data = _contexto.Rooms;

        var d = new RoomResumeDto
        {
            TotalTaken = await data.CountAsync(x => x.Status == RoomStatus.Reservada),
            TotalFree = await data.CountAsync(x => x.Status == RoomStatus.Libre),
            TotalRooms = await data.CountAsync(),
            TotalMaintenance = await data.CountAsync(x => x.Status == RoomStatus.Mantenimiento)
        };

        var dto = new RoomResumeDto()
        {
            //Data = data.Select(x => new RoomDto()
            //{
            //    RoomId = x.RoomId,
            //    RoomNumber = x.RoomNumber,
            //    Type = x.Type,
            //    Capacity = x.Capacity,
            //    Status = x.Status,
            //    ImageUrl = x.ImageUrl,
            //    Price = x.Price,
            //    Description = x.Description
            //}),
            //Types = groups.Select(x => new RoomGroupResponseDto
            //{
            //    Type = x.Key,
            //    TotalFree = x.Count(x => x.Status == RoomStatus.Libre),
            //    TotalTaken = x.Count(x => x.Status == RoomStatus.Reservada),
            //    TotalMaintenance = x.Count(x => x.Status == RoomStatus.Mantenimiento),
            //    Total = x.Count()
            //}),

            //TotalRooms = data.Count(),
            //TotalTaken = data.Count(x => x.Status == RoomStatus.Reservada),
            //TotalFree = data.Count(x => x.Status == RoomStatus.Libre),
            //TotalMaintenance = data.Count(x => x.Status == RoomStatus.Mantenimiento),
            //Sencilla = data.Count(x => x.Type == RoomType.Sencilla),
            //Doble = data.Count(x => x.Type == RoomType.Doble),
            //Familiar = data.Count(x => x.Type == RoomType.Familiar),
            //Triple = data.Count(x => x.Type == RoomType.Triple),
            //King = data.Count(x => x.Type == RoomType.King),
            //Presidencial = data.Count(x => x.Type == RoomType.Presidencial),
            //Mini = data.Count(x => x.Type == RoomType.Mini),
        };



        return d;
    }

    public List<AvailableRoomsDto> GetAvailableRooms(RoomTypes? type)
    {
        var query = _contexto.Rooms
        .Where(x => x.Status == RoomStatus.Libre);

        if (type is not null)
        {
            query = query.Where(x => x.Type == type.ToString());
        }

        var result = query
             .GroupBy(x => x.Type)
             .Select(x => new AvailableRoomsDto
             {
                 Type = x.Key,
                 Rooms = x.Select(x => x.RoomNumber).ToList(),
                 Count = x.Count()
             });

        return result.ToList();
    }

    public List<RoomDto> GetAvailableRoomsByReservationConsecutive(string Consecutive)
    {
        Reservation? reservation = _contexto.Reservations
     .Include(x => x.ReservationRooms)
     .Where(x => x.ReservationConsecutive == Consecutive)
     .FirstOrDefault();

        if (reservation != null)
        {
            List<string> typeOfRoomsforReserve = reservation
                .ReservationRooms
                .Where(x => x.ReservationId == reservation.ReservationId)
                .Select(x => x.TypeRoom).ToList();

            var result = _contexto.Rooms.Where(x => x.Status == RoomStatus.Libre &&  typeOfRoomsforReserve.Contains(x.Type));

            //if (typeOfRoomsforReserve.Any())
            //{
            //    var filteredRooms = result.Where(x => typeOfRoomsforReserve.Contains(x.Type));

                List<RoomDto> dto = result.Select(item => new RoomDto
                {
                    Description = item.Description,
                    RoomId = item.RoomId,
                    RoomNumber = item.RoomNumber,
                    ImageUrl = item.ImageUrl,
                    Capacity = item.Capacity,
                    Price = item.Price,
                    Status = item.Status,
                    Type = item.Type
                }).ToList();

                return dto;
            //}
        }

        return null;



    }

    public class AvailableRoomsDto
    {
        public string Type { get; set; }
        public int Count { get; set; }
        public List<string> Rooms { get; set; }
    }
}
