using Microsoft.EntityFrameworkCore;
using S11.Common.Enums;
using S11.Data.Models;

namespace S11.Data.Seeds
{
    public static class Issues
    {
        private static List<Issue> _incidencias;

        public static void Seed(ModelBuilder modelBuilder)
        {
            _incidencias = new List<Issue> {
                new Issue()
                {
                    IssueId = 1,
                    Area ="Habitaciones",
                    Category = 1,
                    Description = "Una de las cortinas de la ventana principal presenta deterioro en el sistema de apertura. Falta el cordón",
                    Title = "Daño en Velo Ventana",
                    RoomId = "402-b",
                    DateIssue = new DateTime(),
                    Status = IssueType.ToDo,
                    //TODO pendiente para definitr usuarios en Seed
                    ReportedBy = 1,
                    GuestId    = 0,
                },
                new Issue()
                {
                    IssueId = 2,
                    Area ="Baños",
                    Category = 2,
                    Description = "La cisterna presenta flujo continuo de agua, se hizo revision manual pero persiste problema, se solicita visita concerje",
                    Title = "Cisterna presenta fuga",
                    RoomId = "304-a",
                    DateIssue = new DateTime(),
                    Status = IssueType.ToDo,
                    //TODO pendiente para definitr usuarios en Seed
                    ReportedBy = 1,
                    GuestId    = 0,
                },

            };

            modelBuilder.Entity<Issue>().HasData(_incidencias);
        }
    }
}
