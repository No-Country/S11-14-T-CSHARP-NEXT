﻿// <auto-generated />
using System;
using HotelWiz.Back.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelWiz.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231102172533_add-room-name")]
    partial class addroomname
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelWiz.Back.Data.Models.Issue", b =>
                {
                    b.Property<int>("IssueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IssueId"));

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateIssue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GuestId")
                        .HasColumnType("int");

                    b.Property<int>("ReportedBy")
                        .HasColumnType("int");

                    b.Property<string>("RoomId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IssueId");

                    b.ToTable("Issues");

                    b.HasData(
                        new
                        {
                            IssueId = 1,
                            Area = "Habitaciones",
                            Category = 1,
                            DateIssue = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Una de las cortinas de la ventana principal presenta deterioro en el sistema de apertura. Falta el cordón",
                            GuestId = 0,
                            ReportedBy = 1,
                            RoomId = "A-101",
                            Status = "ToDo",
                            Title = "Daño en Velo Ventana"
                        },
                        new
                        {
                            IssueId = 2,
                            Area = "Baños",
                            Category = 2,
                            DateIssue = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "La cisterna presenta flujo continuo de agua, se hizo revision manual pero persiste problema, se solicita visita concerje",
                            GuestId = 0,
                            ReportedBy = 1,
                            RoomId = "A-102",
                            Status = "ToDo",
                            Title = "Cisterna presenta fuga"
                        });
                });

            modelBuilder.Entity("HotelWiz.Back.Data.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<DateTime?>("CheckInActualDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckInExpectedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckOutActualDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckOutExpectedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuestAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestDocumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GuestDocumentType")
                        .HasColumnType("int");

                    b.Property<string>("GuestEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<string>("ReservationAmenities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservationConsecutive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            CheckInExpectedDate = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOutExpectedDate = new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestDocumentNumber = "1",
                            GuestDocumentType = 2,
                            GuestEmail = "Guest1@example.com",
                            GuestName = "Guest1",
                            NumberOfGuests = 0,
                            NumberOfRooms = 0,
                            ReservationConsecutive = "W2325021",
                            Status = 0
                        },
                        new
                        {
                            ReservationId = 2,
                            CheckInExpectedDate = new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOutExpectedDate = new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestDocumentNumber = "2",
                            GuestDocumentType = 2,
                            GuestEmail = "Guest2@example.com",
                            GuestName = "Guest2",
                            NumberOfGuests = 0,
                            NumberOfRooms = 0,
                            ReservationConsecutive = "W2325022",
                            Status = 0
                        },
                        new
                        {
                            ReservationId = 3,
                            CheckInExpectedDate = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOutExpectedDate = new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestDocumentNumber = "3",
                            GuestDocumentType = 2,
                            GuestEmail = "Guest3@example.com",
                            GuestName = "Guest3",
                            NumberOfGuests = 0,
                            NumberOfRooms = 0,
                            ReservationConsecutive = "W2325023",
                            Status = 0
                        });
                });

            modelBuilder.Entity("HotelWiz.Back.Data.Models.ReservationRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("RoomName")
                        .HasColumnType("int");

                    b.Property<string>("TypeRoom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("ReservationRoom");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ReservationId = 1,
                            RoomId = 0,
                            RoomName = 0,
                            TypeRoom = "Sencilla"
                        },
                        new
                        {
                            Id = 2,
                            ReservationId = 2,
                            RoomId = 0,
                            RoomName = 0,
                            TypeRoom = "Mini"
                        },
                        new
                        {
                            Id = 3,
                            ReservationId = 3,
                            RoomId = 0,
                            RoomName = 0,
                            TypeRoom = "Triple"
                        });
                });

            modelBuilder.Entity("HotelWiz.Back.Data.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("HotelWiz.Back.Data.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            Capacity = 1,
                            Description = "A single room",
                            ImageUrl = "https://www.collinsdictionary.com/images/full/singleroom_713511961_1000.jpg",
                            Price = 2000m,
                            RoomNumber = "A-101",
                            Status = "Reservada",
                            Type = "Sencilla"
                        },
                        new
                        {
                            RoomId = 2,
                            Capacity = 2,
                            Description = "A Double room",
                            ImageUrl = "https://www.hotel7dublin.com/wp-content/uploads/Hotel-7-double-bedroom.jpg",
                            Price = 3000m,
                            RoomNumber = "A-102",
                            Status = "Libre",
                            Type = "Doble"
                        },
                        new
                        {
                            RoomId = 3,
                            Capacity = 7,
                            Description = "A familiar room",
                            ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200",
                            Price = 4000m,
                            RoomNumber = "A-103",
                            Status = "Mantenimiento",
                            Type = "Familiar"
                        },
                        new
                        {
                            RoomId = 4,
                            Capacity = 5,
                            Description = "A king room",
                            ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200",
                            Price = 5000m,
                            RoomNumber = "A-104",
                            Status = "Mantenimiento",
                            Type = "King"
                        },
                        new
                        {
                            RoomId = 5,
                            Capacity = 9,
                            Description = "A Master room",
                            ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200",
                            Price = 10000m,
                            RoomNumber = "A-105",
                            Status = "Mantenimiento",
                            Type = "Master"
                        },
                        new
                        {
                            RoomId = 6,
                            Capacity = 1,
                            Description = "A Mini room",
                            ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200",
                            Price = 1500m,
                            RoomNumber = "A-106",
                            Status = "Reservada",
                            Type = "Mini"
                        },
                        new
                        {
                            RoomId = 7,
                            Capacity = 3,
                            Description = "A Triple room",
                            ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200",
                            Price = 7500m,
                            RoomNumber = "A-107",
                            Status = "Reservada",
                            Type = "Triple"
                        },
                        new
                        {
                            RoomId = 8,
                            Capacity = 4,
                            Description = "A Presidencial room",
                            ImageUrl = "https://image-tc.galaxy.tf/wijpeg-7ng0vu8db011ivkzeiidl1yqg/family-room-suites-individual-page-2_wide.jpg?crop=0%2C103%2C1980%2C1114&width=1200",
                            Price = 30000m,
                            RoomNumber = "A-108",
                            Status = "Libre",
                            Type = "Presidencial"
                        });
                });

            modelBuilder.Entity("HotelWiz.Back.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "CONCURRENCY_STAMP",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Admin User",
                            ImageUrl = "",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAENuVTgwjk8yvLXr+xSORq6dDe+uyLj+MpehjYz+2qqs07aJpBIFXhkVcm1hJJ2LYPg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "CONCURRENCY_STAMP",
                            Email = "user1@gmail.com",
                            EmailConfirmed = true,
                            FullName = "User Test 1",
                            ImageUrl = "",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@GMAIL.COM",
                            NormalizedUserName = "USER1",
                            PasswordHash = "AQAAAAIAAYagAAAAEPq6AxWxBIh+tOXYgQMHuQ4WSJAl2vdTAOfuljoFMhVYQjhTw6ofZni31IAtzZhUOw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user1"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "CONCURRENCY_STAMP",
                            Email = "user2@gmail.com",
                            EmailConfirmed = true,
                            FullName = "User Test 2",
                            ImageUrl = "",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@GMAIL.COM",
                            NormalizedUserName = "USER2",
                            PasswordHash = "AQAAAAIAAYagAAAAECymU8aq5ovuZDwKjza/S51M3VIFUNSpbaPtfZeSwHgbkpQONTvdNMVNb/dWGOARWw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HotelWiz.Back.Data.Models.ReservationRoom", b =>
                {
                    b.HasOne("HotelWiz.Back.Data.Models.Reservation", "Reservation")
                        .WithMany("ReservationRooms")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("HotelWiz.Back.Data.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("HotelWiz.Back.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("HotelWiz.Back.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("HotelWiz.Back.Data.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelWiz.Back.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("HotelWiz.Back.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelWiz.Back.Data.Models.Reservation", b =>
                {
                    b.Navigation("ReservationRooms");
                });
#pragma warning restore 612, 618
        }
    }
}
