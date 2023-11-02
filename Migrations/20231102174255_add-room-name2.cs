using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelWiz.Migrations
{
    /// <inheritdoc />
    public partial class addroomname2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "ReservationRoom",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEPbHcSieoowT5Hb9NpbBU7FasmnKYdqtQBYPkCGij1tTSK+x1URQGYsL8KfSKPbng==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBAD6Jv/efZRC8uh3s5ad1zj9Gw5mnfoY+cTKTM7GDVeESoQDsta9hwFAwB30l5aww==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEILg6BAzplJnmkD1YCrzrH3rf/uwtzWnEKZo2IawImY7f3MwLLGimyctPMfIgoCeZg==");

            migrationBuilder.UpdateData(
                table: "ReservationRoom",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoomName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ReservationRoom",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoomName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ReservationRoom",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoomName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationConsecutive",
                value: "W2342021");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationConsecutive",
                value: "W2342022");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationConsecutive",
                value: "W2342023");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RoomName",
                table: "ReservationRoom",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
