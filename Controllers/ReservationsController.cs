﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using S11.Common.Dto;
using S11.Common.Dto.Reservation;
using S11.Common.Mappers;
using S11.Data.Models;
using S11.Data;
using S11.Services;
using System.Security.Claims;
using static S11.Services.ReservationsService;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Text.Json.Serialization;
using static S11.Common.Enums.Reservations.Reservations;

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


        [HttpPost(nameof(Create))]
        public ActionResult<IReservationDto> Create(ReservationDto reserva)
        {
            var reservation = _reservationsService.Create(reserva);
            return Ok(reservation);

        }

        //TODO temp while PagedResponse gets merged
        public class GenericCollectionResponse<T> where T : class
        {
            public IEnumerable<T> Data { get; set; }
        }

        [HttpGet("statuses")]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Client)]
        public object Statuses()
        {
            return Enum.GetNames(typeof(ReservationStatus)).Select( (x,index) => new 
            {
                Value = index,
                Text = x
            });
        }

        [HttpPost("{reservationNumber}/status")]
        public ActionResult<ReservationDto> ChangeReservationStatus(string reservationNumber, ReservationStatus newStatus)
        {
            var resChanged = _reservationsService.ChangeReservationStatus(reservationNumber, newStatus);
            return  resChanged!=null? Ok(resChanged): NotFound();
        }
    }
}
