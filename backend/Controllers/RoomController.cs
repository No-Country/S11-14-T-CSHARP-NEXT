using Microsoft.AspNetCore.Mvc;
using S11.Common.Dto;
using S11.Services;

namespace S11.Controllers;

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
}