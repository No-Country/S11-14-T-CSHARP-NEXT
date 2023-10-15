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
                    IsTaken = table.Column<bool>(type: "bit", nullable: false)
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
                value: "AQAAAAIAAYagAAAAEF9mm6gg6cnk6+XS5eAi8wPkMazUbLOAL5oolpdnv/PQN+4yBC5K1Nwauz8YVuukww==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHrGO0hTVjl5Cc6PDi2rOJwY+jUMSMXYnA5XkrmlynkL1H6zKQmeeqd7yf4Dwa1TsA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAPdK1Gev9itxXX0RvtB8L1Dg6W2H2w8pkWJlZBZ86ZWwJAZwwscmcPcDvHmg7IVDA==");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Capacity", "IsTaken", "RoomNumber", "Type" },
                values: new object[,]
                {
                    { 1, 1, true, "A-101", "Sencilla" },
                    { 2, 2, false, "A-102", "Doble" },
                    { 3, 3, true, "A-103", "Familiar" }
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
