using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace S11.Data.Migrations
{
    /// <inheritdoc />
    public partial class rolesreservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole<int>");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationConsecutive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuestCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuestAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuestDocumentType = table.Column<int>(type: "int", nullable: false),
                    GuestDocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "int", nullable: false),
                    ReservationAmenities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CheckInExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckOutExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckInActualDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckOutActualDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELsq/Y3/OJy9BbaZU6s5C1fnLcdtPMpGPK6PeEyBTLKwuG5w5z2QhE3S4L0B1tngZw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHgms1W7onzc7BLAmAgBc7E4bRJ+V+kxD2iA+OE+gIjYLVNimUJ1XPoUXn9BPP86Nw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMivYMpUTLDwnZ5Jglx4Y6k8JPSTs6zA7n7QjAxrc6C2hry9IZAjbDWD0AEDEQ22xQ==");

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CheckInActualDate", "CheckInExpectedDate", "CheckOutActualDate", "CheckOutExpectedDate", "GuestAddress", "GuestCountry", "GuestDocumentNumber", "GuestDocumentType", "GuestEmail", "GuestName", "GuestPhoneNumber", "NumberOfGuests", "NumberOfRooms", "ReservationAmenities", "ReservationConsecutive", "RoomIds", "RoomType", "Status" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "1", 2, "Guest1@example.com", "Guest1", null, 0, 0, null, "W2326171", null, null, 0 },
                    { 2, null, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2", 2, "Guest2@example.com", "Guest2", null, 0, 0, null, "W2326172", null, null, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.CreateTable(
                name: "IdentityRole<int>",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole<int>", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "IdentityRole<int>",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "User", "USER" }
                });
        }
    }
}
