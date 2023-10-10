using System.ComponentModel.DataAnnotations;

namespace S11.Data.Models;

public class Incidencia
{
    [Key]
    public int Incidencia_Id { get; set; }
    public DateTime FechaIncidencia { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    //FK
    public int ReportadoPor { get; set; }
    public string Area { get; set; }
    //fk
    public string HabitacionId { get; set; }
    //fk
    public int HuespedId { get; set; }
    //fk or seed
    public int Categoria { get; set; }
    public string Estado { get; set; }


    //public string[] Imagenes { get; set; }
    //public string[] Videos { get; set; }
}
