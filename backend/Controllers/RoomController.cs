using Microsoft.AspNetCore.Mvc;
using S11.Common.Dto;
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
        public IEnumerable<RoomDto> GetRooms()
        {
            return _roomService.GetRooms();
        }

        [HttpGet("{id}")]
        public ActionResult<RoomDto> GetRoomById(int id)
        { 
            var room = _roomService.GetRoomById(id);

            return room != null ? Ok(room) : NotFound($"Room with {id} was not found");
        }
    }
}