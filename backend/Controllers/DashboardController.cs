using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Attributes;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.Dynamic;
using System.Text.Json.Serialization;


//TODO conectar con los respectivos servicios para obtener la data o crear un servicio especifico
//TODO convenga talvez devolver las primeraas 10 reservas ordenadas por default fecha y las primeras 10 incidencias ordenadas por fecha

namespace S11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        [HttpGet]
        [ApiVersion("0.1")]
        //[Authorize]
        public TempDashBoardResponse GetDashboardBoardResponse()
        {
            return new TempDashBoardResponse();
        }
    }


    [DisplayName("DashboardResume")]
    public class TempDashBoardResponse
    {

        public DateTime FechaConsulta { get; set; }
        public HabitacionesTemp Habitaciones { get; set; }
        public EmpleadosTemp Empleados { get; set; }
        public ReservacionesTemp Reservaciones { get; set; }
        public IncidenciasTemp Incidencias { get; set; }

        public TempDashBoardResponse()
        {
            FechaConsulta = DateTime.Now;

            Habitaciones = new HabitacionesTemp()
            {
                Disponibles = 1,
                Ocupadas = 20,
                Total = 21,
                Reparacion = 0
            };
            Empleados = new EmpleadosTemp() { };
            Reservaciones = new ReservacionesTemp() { };
            Incidencias = new IncidenciasTemp() { };
        }
    }

    [DisplayName("HabitacionesResume")]
    public class HabitacionesTemp
    {
        public int Disponibles { get; set; }
        public int Ocupadas { get; set; }
        public int Reparacion { get; set; }
        public int Total { get; set; }
    }


    [DisplayName("EmpleadoResume")]
    public class EmpleadosTemp
    {
        public int EnTurno { get; set; }
        public int EnVacaciones { get; set; }
        public int Total { get; set; }
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



    [DisplayName("IncidenciaResume")]
    public class IncidenciasTemp
    {
        public int Pendientes { get; set; }
        public int EnAtencion { get; set; }
        public int Resueltas { get; set; }
        public int Total { get; set; }
        public List<IncidenciaDto> Data { get; set; } = new();
    }

    [DisplayName("Incidencia")]
    public class IncidenciaDto
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Estado { get; set; }
        public string Titulo { get; set; }
    }

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
