using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelWiz.Migrations
{
    /// <inheritdoc />
    public partial class addroomname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomName",
                table: "ReservationRoom",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENuVTgwjk8yvLXr+xSORq6dDe+uyLj+MpehjYz+2qqs07aJpBIFXhkVcm1hJJ2LYPg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPq6AxWxBIh+tOXYgQMHuQ4WSJAl2vdTAOfuljoFMhVYQjhTw6ofZni31IAtzZhUOw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECymU8aq5ovuZDwKjza/S51M3VIFUNSpbaPtfZeSwHgbkpQONTvdNMVNb/dWGOARWw==");

            migrationBuilder.UpdateData(
                table: "ReservationRoom",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoomName",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ReservationRoom",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoomName",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ReservationRoom",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoomName",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationConsecutive",
                value: "W2325021");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationConsecutive",
                value: "W2325022");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationConsecutive",
                value: "W2325023");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomName",
                table: "ReservationRoom");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPOLBAYr/5DCimNYduRExDCzOSnu0kJpQEAYlZDEoWXVUZ/LuJOQEWCqp3qm7RB4ZA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENqAWmOUUrNEweIQ/SAg0ffvLCi4eXk8KXqIz8ohS0Usriq0JPWVKTFkMO6AxtjJeA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEjqTmjf5j+1K/0aSHK8YZzfJR+GsGfit1q/BtKO7mRtSsiRy64TdTMpGzoNMSZIsg==");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationConsecutive",
                value: "W2356021");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationConsecutive",
                value: "W2356022");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationConsecutive",
                value: "W2356023");
        }
    }
}
