using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using S11.Common.Dto;
using S11.Common.Enums;
using S11.Common.Extensions;
using S11.Common.Helpers;
using S11.Services;

namespace S11.Controllers
{
    public class RoomsController : BaseApiController
    {
        private readonly RoomService _roomService;

        public RoomsController(RoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]

        public async Task<PagedList<RoomDto>> GetRooms([FromQuery] RoomParams roomParams)
        {
            var rooms = await _roomService.GetRooms(roomParams);
            Response.AddPaginationHeader(rooms.MetaData);
            return rooms;

        }

        [HttpGet("{id}")]
        public ActionResult<RoomDto> GetRoomById(int id)

        {

            var room = _roomService.GetRoomById(id);

            return room != null ? Ok(room) : NotFound($"Room with {id} was not found");
        }

        [HttpGet("types")]
        public object GetRoomTypes()
        {
            var types = Enum.GetNames(typeof(RoomTypes)).Select(x => new
            {
                Type = x.ToString(),
                Value =  Enum.Parse(typeof(RoomTypes),x)

            }).ToList();

            return types;
        }

        [HttpGet("available")]
        [HttpGet("available/{roomType}")]
        public List<AvailableRoomsDto> GetAvailableRooms(RoomTypes? roomType =null)
        {
           return _roomService.GetAvailableRooms(roomType);
        }
    }
}