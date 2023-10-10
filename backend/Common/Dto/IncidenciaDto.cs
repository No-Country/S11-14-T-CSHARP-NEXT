using System.ComponentModel.DataAnnotations;

namespace S11.Common.Dto
{
    public class IncidenciaDto
    {
        public int Incidencia_Id { get; set; }
        public DateTime FechaIncidencia { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int ReportadoPor { get; set; }
        public string Area { get; set; }
        public string HabitacionId { get; set; }
        public int HuespedId { get; set; }
        public int Categoria { get; set; }
        public string Estado { get; set; }
    }
}
