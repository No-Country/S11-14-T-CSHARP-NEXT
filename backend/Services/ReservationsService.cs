using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Validations;
using S11.Common.Dto.Reservation;
using S11.Common.Enums;
using S11.Common.Mappers;
using S11.Controllers;
using S11.Data;
using S11.Data.Models;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using static S11.Common.Enums.PeopleIdentity;
using static S11.Common.Enums.Reservations.Reservations;
using static S11.Services.ReservationsService;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


        public ReservationsResumeDto GetResume()
        {
            var gouped = _contexto.Reservations.GroupBy(x => x.Status).Select(x => new
            {
                Key = x.Key,
                Count = x.Count(),
            }).ToList();

            var resume = new ReservationsResumeDto
            {
                Pending = gouped.FirstOrDefault(x => x.Key == ReservationStatus.OnHold)?.Count??0,
                Accepted = gouped.FirstOrDefault(x => x.Key == ReservationStatus.Accepted)?.Count??0,
                Cancelled = gouped.FirstOrDefault(x => x.Key == ReservationStatus.Cancelled)?.Count??0,
                Finished = gouped.FirstOrDefault(x => x.Key == ReservationStatus.Finished)?.Count??0,
                Total = Enumerable.Sum(gouped.Select(x => x.Count)),
                //TODO only accepted?? 
                Data = _contexto.Reservations
                    .OrderBy(x => x.CheckInExpectedDate)
                    .Take(10)
                    .MapperReservaToDto()
                    .Cast<ReservationDto>()
                    .ToList()
            };

            return resume;
        }

        /// <summary>since is a generic by property can resolve to a collection , a guest can have more tha one reservation </summary>
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

        // Método para agregar una habitación a una reserva
        public void AddRoomToReservation(int reservationId, int roomId)
        {
            var reservation = _contexto.Reservations.FirstOrDefault(r => r.ReservationId == reservationId);
            var room = _contexto.Rooms.FirstOrDefault(r => r.RoomId == roomId);

            if (reservation != null && room != null)
            {
                if (string.IsNullOrEmpty(reservation.RoomIds))
                {
                    reservation.RoomIds = roomId.ToString();
                }
                else
                {
                    reservation.RoomIds += $",{roomId}";
                }
            }
        }
        //TODO Blocked until PagedResponse
        [Obsolete]
        public void GetAllReservationsPaged(IReservationFilter filter)
        {
            throw new NotImplementedException();
        }

        public Reservation Create(ReservationDto reserva)
        {
            var newReservation = new Reservation();
            newReservation.GuestName = reserva.GuestName;
            newReservation.GuestEmail = reserva.GuestName;
            newReservation.GuestDocumentNumber = reserva.GuestDocumentNumber;
            newReservation.CheckInExpectedDate = reserva.CheckOutExpectedDate;
            newReservation.GuestDocumentType =reserva.GuestDocumentType;
            newReservation.Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), reserva.Status.ToString());
            newReservation.ReservationRooms = new List<ReservationRoom>();
            foreach(var temp in reserva.ReservationRooms )
            {
                var reservationRoom = new ReservationRoom();
                reservationRoom.ReservationId = newReservation.ReservationId;
                reservationRoom.TypeRoom = temp;
                
                newReservation.ReservationRooms.Add(reservationRoom);
            }
            _contexto.Reservations.Add(newReservation);
            _contexto.SaveChanges();

            return newReservation;



        }

        /// <summary> Change the status of a reservation </summary>
        /// <returns>if not found return null</returns>
        public ReservationDto? ChangeReservationStatus(string consecutive, ReservationStatus newStatus)
        {
           
            //this can raise an exception, 
            var res = _contexto.Reservations.SingleOrDefault(x => x.ReservationConsecutive.Trim() == consecutive);
            if(res == null)
            {
                return null;
            }
            //a reserve can only be changed to other statuses excepct when in course to a finished status?
            if (res.Status is ReservationStatus.OnCourse)
            {
                if(newStatus!= ReservationStatus.Finished)
                {
                    //TODO validate this rule
                }
                    
            }
            res.Status = newStatus;
            _contexto.SaveChanges();

            return res.MapperReservationToDto();
        }
    }

#region Move to common

    public interface IReservationFilter
    {
    }

    public interface IReservationDto
    {
    }
    #endregion
}
