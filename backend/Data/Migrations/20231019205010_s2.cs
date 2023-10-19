using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace S11.Data.Migrations
{
    /// <inheritdoc />
    public partial class s2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                    CheckOutActualDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                });

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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "CONCURRENCY_STAMP", "admin@gmail.com", true, "Admin User", "", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEN+Bk3DcC3kV/Iojg945ZfLnA3KxGXxrub/EDjn0WUzdq8jpuci8LLE6OK2M1Ap92A==", null, false, "", false, "admin" },
                    { 2, 0, "CONCURRENCY_STAMP", "user1@gmail.com", true, "User Test 1", "", false, null, "USER1@GMAIL.COM", "USER1", "AQAAAAIAAYagAAAAEKSHcWoZ/GYVWJ/sJl9HqtMR7QZeS+EnMDlziPT+SGsAL/oIghNyST5ajJJd9V2Abg==", null, false, "", false, "user1" },
                    { 3, 0, "CONCURRENCY_STAMP", "user2@gmail.com", true, "User Test 2", "", false, null, "USER2@GMAIL.COM", "USER2", "AQAAAAIAAYagAAAAEM5a3bd6R+/Qqt3USeK3wfdtGxZTt0OlnC7pzU4GgAFTM7EuTMCJcsWs0MdKDBtJrw==", null, false, "", false, "user2" }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "IssueId", "Area", "Category", "DateIssue", "Description", "GuestId", "ReportedBy", "RoomId", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "Habitaciones", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Una de las cortinas de la ventana principal presenta deterioro en el sistema de apertura. Falta el cordón", 0, 1, "402-b", "ToDo", "Daño en Velo Ventana" },
                    { 2, "Baños", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La cisterna presenta flujo continuo de agua, se hizo revision manual pero persiste problema, se solicita visita concerje", 0, 1, "304-a", "ToDo", "Cisterna presenta fuga" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CheckInActualDate", "CheckInExpectedDate", "CheckOutActualDate", "CheckOutExpectedDate", "GuestAddress", "GuestCountry", "GuestDocumentNumber", "GuestDocumentType", "GuestEmail", "GuestName", "GuestPhoneNumber", "NumberOfGuests", "NumberOfRooms", "ReservationAmenities", "ReservationConsecutive", "RoomIds", "RoomType", "Status", "TotalValue" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "1", 2, "Guest1@example.com", "Guest1", null, 0, 0, null, "W2350191", null, null, 0, null },
                    { 2, null, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2", 2, "Guest2@example.com", "Guest2", null, 0, 0, null, "W2350192", null, null, 0, null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
