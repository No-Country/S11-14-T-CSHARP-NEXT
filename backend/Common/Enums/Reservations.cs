namespace S11.Common.Enums
{
    public abstract  class Reservations
    {
        //Estado de la reserva (en espera, aceptada, finalizada, cancelada).
        public enum ReservationStatus
        {
            OnHold,
            Accepted,
            Finished,
            Cancelled
        }

        public enum By 
        {
            ReservationConsecutive,
            NameOfGuest,
            RoomName,
            GuestId,
        }
    }
}
