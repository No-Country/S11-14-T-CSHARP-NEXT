using HotelWiz.Back.Common.Dto.Dashboard;
using HotelWiz.Back.Common.Dto.Reservation;
using HotelWiz.Back.Common.Enums;
using HotelWiz.Back.Common.Mappers;
using HotelWiz.Back.Data;
using HotelWiz.Back.Data.Models;
using Microsoft.EntityFrameworkCore;
using static HotelWiz.Back.Common.Enums.Reservations;

namespace HotelWiz.Back.Services
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
            var reservations = _contexto.Reservations.Include(x => x.ReservationRooms).AsNoTracking();
            return reservations.MapperReservaToDto().Cast<ReservationDto>();
        }

        public ReservationDto? GetReservationByConsecutive(string consecutive)
        {
            var res = GetReservationBy(By.ReservationConsecutive, consecutive);
            return res;
        }


        public async Task<ReservationsResumeDto> GetResume()
        {
            var gouped = await _contexto.Reservations
                .AsNoTracking()
                .GroupBy(x => x.Status).Select(x => new
                {
                    x.Key,
                    Count = x.Count(),
                }).ToListAsync();

            var resume = new ReservationsResumeDto
            {
                Pending = gouped.FirstOrDefault(x => x.Key == ReservationStatus.OnHold)?.Count ?? 0,
                Accepted = gouped.FirstOrDefault(x => x.Key == ReservationStatus.Accepted)?.Count ?? 0,
                Cancelled = gouped.FirstOrDefault(x => x.Key == ReservationStatus.Cancelled)?.Count ?? 0,
                Finished = gouped.FirstOrDefault(x => x.Key == ReservationStatus.Finished)?.Count ?? 0,
                Total = gouped.Select(x => x.Count).Sum(),
                //TODO only accepted?? 
                //Data = _contexto.Reservations
                //    .OrderBy(x => x.CheckInExpectedDate)
                //    .Take(10)
                //    .MapperReservaToDto()
                //    .Cast<ReservationDto>()
                //    .ToList()
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
                    res = _contexto.Reservations
                        // .AsNoTracking()
                        .Include(x => x.ReservationRooms)
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

        public bool AddRoomToReservationChekcin(string reservationConsecutive, int roomId)
        {
            try
            {
                var reservation = _contexto.Reservations.FirstOrDefault(r => r.ReservationConsecutive == reservationConsecutive);
                var room = _contexto.Rooms.FirstOrDefault(r => r.RoomId == roomId);

                if (reservation != null && room != null)
                {
                    room!.Status = RoomStatus.Reservada;
                    var roomReservation = new ReservationRoom();
                    roomReservation.ReservationId = reservation.ReservationId;
                    roomReservation.TypeRoom = room.Type;
                    roomReservation.Reservation = reservation;
                    _contexto.Rooms.Update(room);
                    _contexto.ReservationRoom.Add(roomReservation);
                    _contexto.SaveChanges();
                    return true;
                }
                else { return false; }
            }
            catch { return false; }
        }

        // Método para agregar una habitación a una reserva
        public bool AddRoomToReservation(string reservationConsecutive, int roomId)
        {
            //TODO  1 s4 cambia elestado de la habitacion
            //TODO  1 cambia el estado de la habitacion asignada en ReservaRooms
            //TODO cambia el estado de la reserva pero 

            try
            {
                var reservation = _contexto
                    .Reservations
                    .Include(x => x.ReservationRooms)
                    .FirstOrDefault(r => r.ReservationConsecutive == reservationConsecutive);
                var room = _contexto.Rooms.FirstOrDefault(r => r.RoomId == roomId);

                if (reservation != null && room != null)
                {
                    var roomReservation = reservation.ReservationRooms.First();
                    roomReservation.RoomId = roomId;
                    roomReservation.RoomName = room.RoomNumber;
                    _contexto.Entry(roomReservation).State = EntityState.Modified;
                    room.Status = RoomStatus.Reservada;
                    //_contexto.ReservationRoom.Add(roomReservation);
                    _contexto.SaveChanges();
                    return true;
                }
                else { return false; }
            }
            catch { return false; }
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
            newReservation.GuestDocumentType = reserva.GuestDocumentType;
            newReservation.Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), reserva.Status.ToString());
            newReservation.ReservationRooms = new List<ReservationRoom>();
            foreach (var temp in reserva.ReservationRooms)
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
            if (res == null)
            {
                return null;
            }
            //a reserve can only be changed to other statuses excepct when in course to a finished status?
            if (res.Status is ReservationStatus.OnCourse)
            {
                if (newStatus != ReservationStatus.Finished)
                {
                    //TODO validate this rule
                }

            }
            res.Status = newStatus;
            _contexto.SaveChanges();

            return res.MapperReservationToDto();
        }

        /// <summary>
        /// Will search by Name, consecutove and email
        /// </summary>
        /// <param name="param"></param>
        /// <returns>Reservations that contains the term</returns>
        public List<ReservationDto> SearchReservations(string param)
        {
            var results = _contexto.Reservations
                 .Where(x => x.ReservationConsecutive.Contains(param) || x.GuestEmail.Contains(param) || x.GuestName.Contains(param))
                 .MapperReservaToDto().Cast<ReservationDto>().ToList();

            return results;
        }

        public ReservationDto Checkin(string consecutive)
        {
            //todo do the checkin
            //change status
            var res = _contexto.Reservations
                .Include(x => x.ReservationRooms)
                .First(x => x.ReservationConsecutive == consecutive);

            var nigths = (res.CheckOutExpectedDate - res.CheckInExpectedDate).Value.TotalDays;
            res.TotalValue =
                _contexto.Rooms.Find(res.ReservationRooms.FirstOrDefault().RoomId).Price * (decimal)nigths;

            _contexto.Entry(res).State = EntityState.Modified;
            _contexto.SaveChanges();

            return this.ChangeReservationStatus(consecutive, ReservationStatus.OnCourse);
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
