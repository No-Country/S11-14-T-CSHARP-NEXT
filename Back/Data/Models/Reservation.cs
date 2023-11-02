using static HotelWiz.Back.Common.Enums.PeopleIdentity;
using static HotelWiz.Back.Common.Enums.Reservations;

namespace HotelWiz.Back.Data.Models
{/*
  
  Código de reserva.

Documento de identidad del usuario.

Nombre del usuario.

Tipo de habitación reservada.

Estado de la reserva (en espera, aceptada, finalizada, cancelada).

Número de habitación asignada (si está aceptada).

Fecha de check-in.
  */



    /*
     
     Funcionalidad de búsqueda:

Debe haber una opción de búsqueda que permita al administrador buscar una reserva por su código, el documento de identidad de la persona o el nombre del usuario.

Filtrado por estado de reserva:

Debe ser posible filtrar las reservas por su estado (en espera, aceptada, finalizada, cancelada).

Filtrado por fecha de check-in:

Debe ser posible filtrar las reservas por la fecha de check-in, permitiendo seleccionar un rango de fechas.

Ordenamiento de la lista:

La lista de reservas debe poder ordenarse por diferentes criterios, como fecha de check-in o estado de la reserva.
     */

    public class Reservation
    {
        //TODO blocked until Rooms is ready
        //TODO 
        public int ReservationId { get; set; }
        public string ReservationConsecutive { get; set; }
        public string GuestName { get; set; }
        public string GuestEmail { get; set; }
        public string? GuestPhoneNumber { get; set; }
        public string? GuestCountry { get; set; }
        public string? GuestAddress { get; set; }
        public IdentityDocumentType GuestDocumentType { get; set; }
        public string GuestDocumentNumber { get; set; }
        public ICollection<ReservationRoom> ReservationRooms { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfGuests { get; set; }
        //array of room Ids
        public string? ReservationAmenities { get; set; }
        //public Room? Room { get; set; }
        //array of rooms Ids
        public string? RoomIds { get; set; }
        public string? RoomType { get; set; }
        public ReservationStatus Status { get; set; }

        public DateTime? CheckInExpectedDate { get; set; }
        public DateTime? CheckOutExpectedDate { get; set; }

        public DateTime? CheckInActualDate { get; set; }
        public DateTime? CheckOutActualDate { get; set; }

        public decimal? TotalValue { get; set; }
    }
}
