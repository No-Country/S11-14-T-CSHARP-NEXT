using HotelWiz.Back.Services;
using static HotelWiz.Back.Common.Enums.PeopleIdentity;

namespace HotelWiz.Back.Common.Dto.Reservation
{
    #region Move to common
    //TODO move to common
    public class ReservationDto : IReservationDto
    {
        public int ReservationId { get; set; }
        public string ReservationConsecutive { get; set; }
        public string GuestName { get; set; }
        public string? GuestEmail { get; set; }
        public string? GuestPhoneNumber { get; set; }
        public string? GuestCountry { get; set; }
        public string? GuestAddress { get; set; }
        public IdentityDocumentType GuestDocumentType { get; set; }
        public string GuestDocumentNumber { get; set; }
        public List<string> ReservationRooms { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfGuests { get; set; }
        //array of room Ids
        public string? ReservationAmenities { get; set; }
        //public Room? Room { get; set; }
        public string? RoomIds { get; set; }
        /// <summary>  Rooms associated to this reservation, type and roomId if assigned </summary>
        public List<(string, string)>? Rooms { get; set; }

        public string Status { get; set; }
        public int StatusCode { get; set; }

        public DateTime? CheckInExpectedDate { get; set; }
        public DateTime? CheckOutExpectedDate { get; set; }

        public decimal? Value { get; set; }
    }
    #endregion
}
