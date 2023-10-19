using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace S11.Migrations
{
    /// <inheritdoc />
    public partial class alfgo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEK0zkCveV/04lWt1lGyYw5RB7mUyUMhive9JH5tXOceHzv19RI3vaHlLdxxZTMsOIg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPh7VWC/VlezPcM1gX3NCh012Hcj4BjAeaFyJiiGmMiuyJG5VBeZ8rjemdJyslH1uQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECrYS8k16z832cfDDMVg1QGyZYRM6ovh4wuMW7bn4voNVDIvVtKX8J59kty14XFOUg==");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationConsecutive",
                value: "W2343191");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationConsecutive",
                value: "W2343192");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC4nZ2DVAwm9kneT/+85tyLPz/1i+rvRNHQhuBBdfSw7X21xduoRejRAVaqKlECw5A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPpwNhPQ1HF8tAs2zsgK/X2/bPAVJ5hFY7moeFVhrcaC0iJUtQbX4gIPcgdjxXu8LA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEKFHyshZsDGx0+NYNWBIJHdcdaLw6YkAsbedcwpwUYRtYd0CaxsSvPGrLJ/ZIgE0g==");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationConsecutive",
                value: "W2356181");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationConsecutive",
                value: "W2356182");
        }
    }
}
