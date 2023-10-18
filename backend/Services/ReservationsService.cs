using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;
using S11.Common.Enums;
using S11.Data;
using S11.Data.Models;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using static S11.Common.Enums.PeopleIdentity;
using static S11.Common.Enums.Reservations;
using static S11.Services.ReservationsService;

namespace S11.Services
{
    public class ReservationsService// : IReservationsService
    {
        private readonly Contexto _contexto;
        public ReservationsService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<ReservationDto> GetAllReservations()
        {
            var reservations = _contexto.Reservations;
            return reservations.MapperReservaToDto().Cast<ReservationDto>();
        }

        public ReservationDto? GetReservationByConsecutive(string consecutive)
        {
            var res = GetReservationBy(By.ReservationConsecutive, consecutive);
            return res;
        }


        /// <summary>since is a genery by property can resolve to a collection since a guest can have more tha one reservation </summary>
        [Obsolete]
        public ReservationDto? GetReservationBy(By by, string value)
        {

            Reservation res = null;
            switch (by)
            {
                case By.ReservationConsecutive:
                    res = _contexto
                        .Reservations
                        .SingleOrDefault(x => x.ReservationConsecutive.Trim() == value.Trim());
                    break;
                //case By.NameOfGuest:
                //    break;
                //case By.RoomName:
                //    break;
                //case By.GuestId:
                //    break;
                default:
                    break;
            }

            return res is null ? null : res.MapperReservationToDto();
        }

        //TODO Blocked until PagedResponse
        [Obsolete]
        public void GetAllReservationsPaged(IReservationFilter filter)
        {
            throw new NotImplementedException();
        }


        #region Move to common

        //TODO move to common
        public class ReservationDto : IReservationDto
        {
            public string ReservationConsecutive { get; set; }
            public string GuestName { get; set; }
            public string? GuestEmail { get; set; }
            public string? GuestPhoneNumber { get; set; }
            public string? GuestCountry { get; set; }
            public string? GuestAddress { get; set; }
            public IdentityDocumentType GuestDocumentType { get; set; }
            public string GuestDocumentNumber { get; set; }

            public int NumberOfRooms { get; set; }
            public int NumberOfGuests { get; set; }
            //array of room Ids
            public string? ReservationAmenities { get; set; }
            //public Room? Room { get; set; }

            //array of rooms Ids an type of room
            public (string, string)? Rooms { get; set; }

            public string Status { get; set; }
            public int StatusCode { get; set; }

            public DateTime? CheckInExpectedDate { get; set; }
            public DateTime? CheckOutExpectedDate { get; set; }
        }


        public class ReservationResumedDto : IReservationDto
        {
            public string ReservationConsecutive { get; set; }
            public string GuestName { get; set; }
            public string? GuestEmail { get; set; }
            public string Status { get; set; }
            public int StatusCode { get; set; }

            public DateTime? CheckInExpectedDate { get; set; }
            public DateTime? CheckOutExpectedDate { get; set; }
        }

        public interface IReservationFilter
        {
        }
    }

    public interface IReservationDto
    {
    }

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
                CheckOutExpectedDate = reservation.CheckOutExpectedDate
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

            resumed.GuestName = String.Join(' ', reservation.GuestName.Split(' ').ToList().Select(x => $"{x.Substring(0, 2)}******"));

            if (!String.IsNullOrEmpty(reservation.GuestEmail))
            {
                var guestEmailSplited = reservation.GuestEmail.Split("@");
                var guestUser = guestEmailSplited[0];
                var domain = guestEmailSplited[1];
                resumed.GuestEmail = $"{guestUser.Substring(0, 2)}***@{domain.Substring(0, 2)}***";

            }
            return resumed;
        }
    } 
    #endregion
}
