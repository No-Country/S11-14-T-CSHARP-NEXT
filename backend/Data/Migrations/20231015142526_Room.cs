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
                    Capacity = table.Column<int>(type: "int", nullable: false)
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
                value: "AQAAAAIAAYagAAAAELLy3jc5ltinXSqJvOaXHHRSP87MNqtY3mVqC8ocscNWt91znxkPFIAHn9jOYfsNHQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECxqUWO3qcSQo9cDpSNwLzv0i1R7aZ/1e0URZG5sVcDyiZHXR2tTzaEqjmzSrLBGPw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJPPJL/wymFB2k/BjV9sWvA31Dq5zSUUYE+6PCGyBb7b5ABAVxT6v3dX0s69UNYPJA==");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Capacity", "RoomNumber", "Type" },
                values: new object[,]
                {
                    { 1, 0, "A-101", "Sencilla" },
                    { 2, 0, "A-102", "Doble" },
                    { 3, 0, "A-103", "Familiar" }
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
