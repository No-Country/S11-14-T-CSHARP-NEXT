using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using S11.Data.Models;
using S11.Services;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using static S11.Services.ReservationsService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace S11.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly ReservationsService _reservationsService;

        public ReservationsController(ReservationsService reservationsService)
        {
            _reservationsService = reservationsService;
        }

        // GET api/<ReservationsController>
        //[Authorize(Roles ="Admin")]
        [HttpGet]
        public ActionResult<GenericCollectionResponse<IReservationDto>> GetAll( /*Filter filter*/)
        {
            //TODO apply filter
            var res = _reservationsService.GetAllReservations(/*filter*/);
            var response = new GenericCollectionResponse<ReservationDto>
            {
                Data = res
            };
            return Ok(response);
        }

        // GET: api/<ReservationsController>/5
        [HttpGet("{reservationNumber}")]
        public ActionResult<IReservationDto> GetByConsecutive(string reservationNumber)
        {
            //TODO this api can be called from admin and user, user will only get resumed reservation, admin will receive a complete res
            //TODO add AsRole parameter on service call AsRole.Admin AsRoleUse, so controller doesnt hold any logic
            var res = _reservationsService.GetReservationByConsecutive(reservationNumber);

            if (res is null) return NotFound();

            var userIsAdmin = User
                .FindAll(ClaimTypes.Role)
                .Any(x => x.Value == "Admin");

            return Ok(userIsAdmin ? res : res.MapperReservationToResumedDto());
        }

        //TODO temp while PagedResponse gets merged
        public class GenericCollectionResponse<T> where T : class
        {
            public IEnumerable<T> Data { get; set; }
        }
    }
}
