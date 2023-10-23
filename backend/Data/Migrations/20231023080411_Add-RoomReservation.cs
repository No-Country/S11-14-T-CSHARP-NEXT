using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace S11.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRoomReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReservationRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    TypeRoom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationRoom_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationRoom_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJoP47zEi6vEyD6YR2Jf5HOu00VY2adwGGbYfAsRHbOFb/t4TmvRBpwZU4wuXHvhlw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOAQW0WYgbJG7WET/2qW5xIWycqM8xG7eP6rRHWyknUwmuKVXF+EC7Fd41pKUxQnVQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKRA1QzHVPYsPlc0XOd0XZHla0pHBCssj7i/GydU34hCLhHHJ8LvT78NF6RHloGiUg==");

            migrationBuilder.InsertData(
                table: "ReservationRoom",
                columns: new[] { "Id", "ReservationId", "RoomId", "TypeRoom" },
                values: new object[,]
                {
                    { 1, 1, null, "Sencilla" },
                    { 2, 2, null, "Mini" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationConsecutive",
                value: "W2304231");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationConsecutive",
                value: "W2304232");

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CheckInActualDate", "CheckInExpectedDate", "CheckOutActualDate", "CheckOutExpectedDate", "GuestAddress", "GuestCountry", "GuestDocumentNumber", "GuestDocumentType", "GuestEmail", "GuestName", "GuestPhoneNumber", "NumberOfGuests", "NumberOfRooms", "ReservationAmenities", "ReservationConsecutive", "RoomIds", "RoomType", "Status", "TotalValue" },
                values: new object[] { 3, null, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "3", 2, "Guest3@example.com", "Guest3", null, 0, 0, null, "W2304232", null, null, 0, null });

            migrationBuilder.InsertData(
                table: "ReservationRoom",
                columns: new[] { "Id", "ReservationId", "RoomId", "TypeRoom" },
                values: new object[] { 3, 3, null, "Triple" });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationRoom_ReservationId",
                table: "ReservationRoom",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationRoom_RoomId",
                table: "ReservationRoom",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationRoom");

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN+Bk3DcC3kV/Iojg945ZfLnA3KxGXxrub/EDjn0WUzdq8jpuci8LLE6OK2M1Ap92A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKSHcWoZ/GYVWJ/sJl9HqtMR7QZeS+EnMDlziPT+SGsAL/oIghNyST5ajJJd9V2Abg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM5a3bd6R+/Qqt3USeK3wfdtGxZTt0OlnC7pzU4GgAFTM7EuTMCJcsWs0MdKDBtJrw==");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationConsecutive",
                value: "W2350191");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationConsecutive",
                value: "W2350192");
        }
    }
}
