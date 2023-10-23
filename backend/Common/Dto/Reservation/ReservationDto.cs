using S11.Data.Models;
using S11.Services;
using static S11.Common.Enums.PeopleIdentity;
using static S11.Common.Enums.Reservations;

namespace S11.Common.Dto.Reservation
{
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
        public List<String> ReservationRooms { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfGuests { get; set; }
        //array of room Ids
        public string? ReservationAmenities { get; set; }
        //public Room? Room { get; set; }
        public string? RoomIds { get; set; }
        //array of rooms Ids an type of room
        public (string, string)? Rooms { get; set; }

        public string Status { get; set; }
        public int StatusCode { get; set; }

        public DateTime? CheckInExpectedDate { get; set; }
        public DateTime? CheckOutExpectedDate { get; set; }

        public decimal? Value { get; set; }
    }
    #endregion
}
