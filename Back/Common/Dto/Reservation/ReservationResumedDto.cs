using HotelWiz.Back.Services;

namespace HotelWiz.Back.Common.Dto.Reservation
{
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

}
