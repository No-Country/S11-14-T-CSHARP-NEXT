using System.ComponentModel;


//TODO conectar con los respectivos servicios para obtener la data o crear un servicio especifico
//TODO convenga talvez devolver las primeraas 10 reservas ordenadas por default fecha y las primeras 10 incidencias ordenadas por fecha

namespace HotelWiz.Back.Common.Dto
{
    [DisplayName("EmpleadoResume")]
    public class EmpleadosResumeDto
    {
        public int EnTurno { get; set; }
        public int EnVacaciones { get; set; }
        public int Total { get; set; }
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
