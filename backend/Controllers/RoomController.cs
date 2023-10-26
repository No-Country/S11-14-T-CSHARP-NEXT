using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using S11.Common.Dto;
using S11.Data;
using S11.Data.Models;
using S11.Common.Extensions;
using S11.Common.Helpers;
using S11.Services;

namespace S11.Controllers
{
    public class RoomController : BaseApiController
    {
        private readonly RoomService _roomService;
        //TODO temp
        private readonly Contexto _context;

        public RoomController(RoomService roomService , Contexto contexto)
        {
            _roomService = roomService;
            _context = contexto; // TODO remove this
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


        [HttpGet("{roomId}/issues")]
        public async Task<ActionResult<IEnumerable<IssueDto>>> GetIssuesByRoomId(string roomId)
        {
            //TODO move to service
            //try to find the room by internal id or by room Name
            roomId = roomId.Trim().ToUpper();
            int _roomId;
            Room room;

            var parsed = Int32.TryParse(roomId, out _roomId);
            if (parsed)
            {
                room = _context.Rooms.FirstOrDefault(x => x.RoomNumber.ToUpper() == roomId || x.RoomId == _roomId);
            }
            else
            {
                room = _context.Rooms.FirstOrDefault(x => x.RoomNumber.ToUpper() == roomId);
            }

            if (room == null)
            {
                return NotFound();
            }

            var issues = _context.Issues.Where(x => x.RoomId == room.RoomNumber);
            if (issues.Any())
            {
                return issues.Select(x => new IssueDto
                {
                    DateIssue = x.DateIssue,
                    Category = x.Category,
                    Area = x.Area,
                    Description = x.Description,
                    GuestId = x.GuestId,
                    IssueId = x.IssueId,
                    ReportedBy = x.ReportedBy,
                    RoomId = x.RoomId,
                    Status = x.Status,
                    Title = x.Title
                }).ToList();
            }
            return Ok(Enumerable.Empty<IssueDto>());
        }
    }
}