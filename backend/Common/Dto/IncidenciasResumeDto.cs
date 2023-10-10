using System.ComponentModel;


//TODO conectar con los respectivos servicios para obtener la data o crear un servicio especifico
//TODO convenga talvez devolver las primeraas 10 reservas ordenadas por default fecha y las primeras 10 incidencias ordenadas por fecha

namespace S11.Common.Dto
{
    [DisplayName("IncidenciaResume")]
    public class IncidenciasResumeDto
    {
        public int Pendientes { get; set; }
        public int EnAtencion { get; set; }
        public int Resueltas { get; set; }
        public int Total { get; set; }
        public IEnumerable<IncidenciaDto> Data { get; set; }
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
