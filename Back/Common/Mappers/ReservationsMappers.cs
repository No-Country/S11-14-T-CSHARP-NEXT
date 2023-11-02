﻿using HotelWiz.Back.Common.Dto.Reservation;
using HotelWiz.Back.Data.Models;
using HotelWiz.Back.Services;

namespace HotelWiz.Back.Common.Mappers
{
    public static class ReservationsMappers
    {
        public static IList<IReservationDto> MapperReservaToDto(this IEnumerable<Reservation> reservations)
        {
            var dots = new List<IReservationDto>();
            foreach (Reservation item in reservations)
            {
                dots.Add(item.MapperReservationToDto());
            }
            return dots;
        }

        //TODO move to Common
        public static ReservationDto MapperReservationToDto(this Reservation reservation)
        {
            var dto = new ReservationDto
            {
                ReservationConsecutive = reservation.ReservationConsecutive,
                GuestName = reservation.GuestName,
                GuestEmail = reservation.GuestEmail,
                Status = reservation.Status.ToString(),
                StatusCode = (int)reservation.Status,
                CheckInExpectedDate = reservation.CheckInExpectedDate,
                CheckOutExpectedDate = reservation.CheckOutExpectedDate,
                Value = reservation.TotalValue,
                ReservationAmenities = reservation.ReservationAmenities,
                GuestAddress = reservation.GuestAddress,
                GuestCountry = reservation.GuestCountry,
                GuestDocumentNumber = reservation.GuestDocumentNumber,
                GuestDocumentType = reservation.GuestDocumentType,
                GuestPhoneNumber = reservation.GuestPhoneNumber,
                NumberOfGuests = reservation.NumberOfGuests,
                NumberOfRooms = reservation.NumberOfRooms,
                RoomIds = reservation.ReservationRooms == null ? null : String.Join(",", reservation.ReservationRooms.Select(x => x.RoomId)),
                //Rooms = reservation.ReservationRooms?.Select( x => (x.TypeRoom,x.RoomId.ToString())).ToList()

                //  ReservationRooms = reservation.ReservationRooms
                //TODO  Complete this
            };
            var rooms = reservation.ReservationRooms?.Select(x => (x.TypeRoom, x.RoomName??"")).ToList();
            dto.Rooms = rooms;
            return dto;
        }
        public static IReservationDto MapperReservationToResumedDto(this ReservationDto reservation)
        {
            var resumed = new ReservationResumedDto
            {
                ReservationConsecutive = reservation.ReservationConsecutive,
                CheckInExpectedDate = reservation.CheckInExpectedDate,
                CheckOutExpectedDate = reservation.CheckOutExpectedDate,
                Status = reservation.Status,
            };

            resumed.GuestName = string.Join(' ', reservation.GuestName.Split(' ').Select(x => $"{x.Substring(0, 2)}******"));

            if (!string.IsNullOrEmpty(reservation.GuestEmail))
            {
                var guestEmailSplited = reservation.GuestEmail.Split("@");
                var guestUser = guestEmailSplited[0];
                var domain = guestEmailSplited[1];
                resumed.GuestEmail = $"{guestUser.Substring(0, 2)}***@{domain.Substring(0, 2)}***";

            }
            return resumed;
        }
    }

}
