using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace S11.Data.Migrations
{
    /// <inheritdoc />
    public partial class Rooms : Migration
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
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                value: "AQAAAAIAAYagAAAAEFl2yFEzRpqvU603kMXAU+QBo8ewFTEFjbZ44j9HTaQStxeJI0FIsi0AdZaMNDgHBA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDmSXgdg39GM/xS/opjzuPvcBxIXyFGCUDjA0Ulw0JMGI/FFXN/pfne+76FfNuFi7Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPNNePPGVYM5s4ZOX7wpEF9litsgz7X8OZHiaJYtqemrzSeTvtY+phScm7MNkOR0Lg==");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Capacity", "Description", "ImageUrl", "Price", "RoomNumber", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 1, "A single room", "https://www.collinsdictionary.com/images/full/singleroom_713511961_1000.jpg", 2000m, "A-101", "Reservada", "Sencilla" },
                    { 2, 2, "A Double room", "https://www.hotel7dublin.com/wp-content/uploads/Hotel-7-double-bedroom.jpg", 3000m, "A-102", "Libre", "Doble" },
                    { 3, 7, "A familiar room", "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200", 4000m, "A-103", "Mantenimiento", "Familiar" },
                    { 4, 5, "A king room", "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200", 5000m, "A-104", "Mantenimiento", "King" },
                    { 5, 9, "A Master room", "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200", 10000m, "A-105", "Mantenimiento", "Master" },
                    { 6, 1, "A Mini room", "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200", 1500m, "A-106", "Reservada", "Mini" },
                    { 7, 3, "A Triple room", "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200", 7500m, "A-107", "Reservada", "Triple" },
                    { 8, 4, "A Presidencial room", "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200", 30000m, "A-108", "Libre", "Presidencial" }
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
