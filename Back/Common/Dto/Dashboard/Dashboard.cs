using System.ComponentModel;
using HotelWiz.Back.Common.Dto;
using HotelWiz.Back.Common.Dto.Reservation;
using HotelWiz.Back.Common.Dto.Room;

namespace HotelWiz.Back.Common.Dto.Dashboard
{
    [DisplayName("DashboardResume")]
    public class TempDashBoardResponse
    {
        public DateTime FechaConsulta { get; set; }
        public RoomResumeDto Rooms { get; set; }
        public EmpleadosResumeDto Empleados { get; set; }
        public ReservationsResumeDto Reservations { get; set; }
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
            Reservations = new ReservationsResumeDto() { };
            Issues = new IssuesResumeDto() { };
        }
    }

    [DisplayName("ReservationsResume")]
    public class ReservationsResumeDto
    {
        public int Pending { get; set; }
        public int CheckIn { get; set; }
        public int Accepted { get; set; }
        public int Finished { get; set; }
        public int Cancelled { get; set; }
        public int Total { get; set; }
        public List<ReservationDto> Data { get; set; } = new();
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
}
