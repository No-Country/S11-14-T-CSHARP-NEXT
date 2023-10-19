using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Attributes;
using S11.Common.Dto;
using S11.Services;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.Dynamic;
using System.Text.Json.Serialization;


//TODO conectar con los respectivos servicios para obtener la data o crear un servicio especifico
//TODO convenga talvez devolver las primeraas 10 reservas ordenadas por default fecha y las primeras 10 incidencias ordenadas por fecha

namespace S11.Controllers
{
    public class DashboardController : BaseApiController
    {
        private readonly IssuesService _incidenciasService;
        private readonly RoomService _roomService;


        public DashboardController(IssuesService incidenciasService, RoomService roomService)
        {
            _incidenciasService = incidenciasService;
            _roomService = roomService;
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
            return dashBoardreport;
        }
        
        
    }

    [DisplayName("DashboardResume")]
    public class TempDashBoardResponse
    {

        public DateTime FechaConsulta { get; set; }
        public RoomResumeDto Rooms { get; set; }
        public EmpleadosResumeDto Empleados { get; set; }
        public ReservacionesTemp Reservaciones { get; set; }
        public IssuesResumeDto Issues { get; set; }

        public TempDashBoardResponse()
        {
            FechaConsulta = DateTime.Now;

            Rooms = new RoomResumeDto() { }; 
            // {
            //     Disponibles = 1,
            //     Ocupadas = 20,
            //     Total = 21,
            //     Reparacion = 0
            // };
            Empleados = new EmpleadosResumeDto() { };
            Reservaciones = new ReservacionesTemp() { };
            Issues = new IssuesResumeDto() { };
        }
    }

    [DisplayName("ReservacionResume")]
    public class ReservacionesTemp
    {
        public int Pendientes { get; set; }
        public int CheckIn { get; set; }
        public int Canceladas { get; set; }
        public int Total { get; set; }
        public List<ReservaDto> Data { get; set; } = new();
    }

    //[DisplayName("Incidencia")]
    //public class IncidenciaDto
    //{
    //    public int id { get; set; }
    //    public string categoria { get; set; }
    //    public string estado { get; set; }
    //    public string titulo { get; set; }
    //}

    [DisplayName("Reserva")]
    public class ReservaDto
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public string NombreHuespedPrincipal { get; set; }
        public int CantidadAdultos { get; set; }
        public int CantidadNinos { get; set; }
        public int CantidadHabitaciones { get; set; }

    }

    //[DisplayName("Habitacion")]
    //public class HabitacionDTO
    //{
    //    public string Numero { get; set; }
    //    public string Tipo { get; set; }
    //    public int Huespedes { get; set; }
    //    public int Ninos { get; set; }
    //}

}
