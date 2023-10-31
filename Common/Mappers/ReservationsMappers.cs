using S11.Common.Dto.Reservation;
using S11.Data.Models;
using S11.Services;

namespace S11.Common.Mappers
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
            return new ReservationDto
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
                RoomIds = reservation.RoomIds,
                //  ReservationRooms = reservation.ReservationRooms
                // Rooms = reservation.Rooms
                //TODO  Complete this
            };
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
