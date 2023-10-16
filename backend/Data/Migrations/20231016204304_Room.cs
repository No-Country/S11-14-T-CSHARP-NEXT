using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace S11.Data.Migrations
{
    /// <inheritdoc />
    public partial class Room : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGcu48ZxrN5Mhrh/UCixbFMVNP0r8X4bLrNYozbq1AnDuPEnm5PvDAol1KAtM7o+Mw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE00Ohovh8K+VntDmvd8+yt3vi/ZJ1ubgPpLkJMQNarr+V4zXVVh7x72cou5Tdaf2Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAxTKhBDJdFq5dYjPNiqX7hiV/7n0RUHth4qXDpzwzFTfsAcbuXv7YEQTwwZrWlR3w==");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Capacity", "RoomNumber", "State", "Type" },
                values: new object[,]
                {
                    { 1, 1, "A-101", "Reservada", "Sencilla" },
                    { 2, 2, "A-102", "Libre", "Doble" },
                    { 3, 3, "A-103", "Mantenimiento", "Familiar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM+BGCPmgNLjnHrdZ6Ve1EO/yM3QEcmEikB5nY05neqMATaIFlFVD5bp361aK9mUAg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEG7XbbgbV6EqR+lAEZ4Lr28UzMD6Kfo6SBarl7kYY9M2CYyyQPZXBo9/RiZ1+Bg7Vw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFHVZpfpeZa6MvWNUk3LAHxg7Ne79aVecLCZa/sCben+c9cOHUnFOXM5xRnujOvAbQ==");
        }
    }
}
