using HotelWiz.Common.Dto.Dashboard;
using Microsoft.AspNetCore.Mvc;
using S11.Common.Dto;
using S11.Common.Dto.Reservation;
using S11.Services;
using System.ComponentModel;


//TODO conectar con los respectivos servicios para obtener la data o crear un servicio especifico
//TODO convenga talvez devolver las primeraas 10 reservas ordenadas por default fecha y las primeras 10 incidencias ordenadas por fecha

namespace S11.Controllers
{
    public class DashboardController : BaseApiController
    {
        private readonly IssuesService _incidenciasService;
        private readonly RoomService _roomService;

        private readonly ReservationsService _resertvationsService;


        public DashboardController(IssuesService incidenciasService, RoomService roomService, ReservationsService resService)
        {
            _incidenciasService = incidenciasService;
            _roomService = roomService;
            _resertvationsService = resService;

        }

        [HttpGet]
        [ApiVersion("0.1")]
        //[Authorize]
        public  TempDashBoardResponse GetDashboardBoardResponse()
        {
            //TODO refactor
            var dashBoardreport = new TempDashBoardResponse();
            dashBoardreport.Issues = _incidenciasService.GetResume();
            dashBoardreport.Rooms =  _roomService.GetResume();

            dashBoardreport.Reservations = _resertvationsService.GetResume();

            return dashBoardreport;
        }
        
        
    }

    //[DisplayName("DashboardResume")]
    //public class TempDashBoardResponse
    //{

    //    public DateTime FechaConsulta { get; set; }
    //    public RoomResumeDto Rooms { get; set; }
    //    public EmpleadosResumeDto Empleados { get; set; }
    //    public ReservationsResumeDto Reservations { get; set; }
    //    public IssuesResumeDto Issues { get; set; }

    //    public TempDashBoardResponse()
    //    {
    //        FechaConsulta = DateTime.Now;

    //        Rooms = new RoomResumeDto() { }; 
    //        // {
    //        //     Disponibles = 1,
    //        //     Ocupadas = 20,
    //        //     Total = 21,
    //        //     Reparacion = 0
    //        // };
    //        Empleados = new EmpleadosResumeDto() { };
    //        Reservations = new ReservationsResumeDto() { };
    //        Issues = new IssuesResumeDto() { };
    //    }
    //}

    //[DisplayName("ReservationsResume")]
    //public class ReservationsResumeDto
    //{
    //    public int Pending { get; set; }
    //    public int CheckIn { get; set; }
    //    public int Accepted { get; set; }
    //    public int Finished { get; set; }
    //    public int Cancelled { get; set; }
    //    public int Total { get; set; }
    //    public List<ReservationDto> Data { get; set; } = new();
    //}



    //[DisplayName("Reserva")]
    //public class ReservaDto
    //{
    //    public DateTime FechaInicio { get; set; }
    //    public DateTime FechaFin { get; set; }
    //    public string Estado { get; set; }
    //    public string NombreHuespedPrincipal { get; set; }
    //    public int CantidadAdultos { get; set; }
    //    public int CantidadNinos { get; set; }
    //    public int CantidadHabitaciones { get; set; }

    //}
}
