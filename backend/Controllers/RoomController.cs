using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using S11.Common.Dto;
using S11.Common.Helpers;
using S11.Services;

namespace S11.Controllers
{
    public class RoomController : BaseApiController
    {
        private readonly RoomService _roomService;

        public RoomController(RoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public async Task<PagedList<RoomDto>> GetRooms([FromQuery] RoomParams roomParams)
        {
            var rooms = await _roomService.GetRooms(roomParams);
            Response.Headers.Add("Pagination", JsonSerializer.Serialize(rooms.MetaData));
            return rooms;

        }

        [HttpGet("{id}")]
        public ActionResult<RoomDto> GetRoomById(int id)

        {

            var room = _roomService.GetRoomById(id);

            return room != null ? Ok(room) : NotFound($"Room with {id} was not found");
        }
    }
}