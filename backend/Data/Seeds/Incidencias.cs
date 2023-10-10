using Microsoft.EntityFrameworkCore;
using S11.Common.Enums;
using S11.Data.Models;

namespace S11.Data.Seeds
{
    public static class Incidencias
    {
        private static List<Incidencia> _incidencias;

        public static void Seed(ModelBuilder modelBuilder)
        {
            _incidencias = new List<Incidencia> {
                new Incidencia()
                {
                    Incidencia_Id = 1,
                    Area ="Habitaciones",
                    Categoria = 1,
                    Descripcion = "Una de las cortinas de la ventana principal presenta deterioro en el sistema de apertura. Falta el cordón",
                    Titulo = "Daño en Velo Ventana",
                    HabitacionId = "402-b",
                    FechaIncidencia = new DateTime(),
                    Estado = TipoIncidencia.Pendiente,
                    //TODO pendiente para definitr usuarios en Seed
                    ReportadoPor = 1,
                    HuespedId    = 0,
                },
                new Incidencia()
                {
                    Incidencia_Id = 2,
                    Area ="Baños",
                    Categoria = 2,
                    Descripcion = "La cisterna presenta flujo continuo de agua, se hizo revision manual pero persiste problema, se solicita visita concerje",
                    Titulo = "Cisterna presenta fuga",
                    HabitacionId = "304-a",
                    FechaIncidencia = new DateTime(),
                    Estado = TipoIncidencia.Pendiente,
                    //TODO pendiente para definitr usuarios en Seed
                    ReportadoPor = 1,
                    HuespedId    = 0,
                },

            };

            modelBuilder.Entity<Incidencia>().HasData(_incidencias);
        }
    }
}
