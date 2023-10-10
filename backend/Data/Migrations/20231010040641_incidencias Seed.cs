using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace S11.Data.Migrations
{
    /// <inheritdoc />
    public partial class incidenciasSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incidencias",
                columns: table => new
                {
                    Incidencia_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaIncidencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportadoPor = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HabitacionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HuespedId = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidencias", x => x.Incidencia_Id);
                });

            migrationBuilder.InsertData(
                table: "Incidencias",
                columns: new[] { "Incidencia_Id", "Area", "Categoria", "Descripcion", "Estado", "FechaIncidencia", "HabitacionId", "HuespedId", "ReportadoPor", "Titulo" },
                values: new object[,]
                {
                    { 1, "Habitaciones", 1, "Una de las cortinas de la ventana principal presenta deterioro en el sistema de apertura. Falta el cordón", "Pendiente", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "402-b", 0, 1, "Daño en Velo Ventana" },
                    { 2, "Baños", 2, "La cisterna presenta flujo continuo de agua, se hizo revision manual pero persiste problema, se solicita visita concerje", "Pendiente", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "304-a", 0, 1, "Cisterna presenta fuga" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidencias");
        }
    }
}
