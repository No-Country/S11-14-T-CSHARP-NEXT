using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace S11.Data.Migrations
{
    /// <inheritdoc />
    public partial class IssuesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    IssueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportedBy = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.IssueId);
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "IssueId", "Area", "Category", "DateIssue", "Description", "GuestId", "ReportedBy", "RoomId", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "Habitaciones", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Una de las cortinas de la ventana principal presenta deterioro en el sistema de apertura. Falta el cordón", 0, 1, "402-b", "ToDo", "Daño en Velo Ventana" },
                    { 2, "Baños", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La cisterna presenta flujo continuo de agua, se hizo revision manual pero persiste problema, se solicita visita concerje", 0, 1, "304-a", "ToDo", "Cisterna presenta fuga" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issues");
        }
    }
}
