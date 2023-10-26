namespace S11.Common.Enums.Reservations
{
  
    public abstract class Reservations
    {
        //Estado de la reserva (en espera, aceptada, finalizada, cancelada).
        public enum ReservationStatus
        {
            /// <summary>pendiente por confirmar </summary>
            OnHold,
            /// <summary>el hotel ha aceptadop la reserva </summary>
            Accepted, //
            /// <summary>el huesped ha hecho checkin</summary>
            OnCourse, //
            /// <summary>el huesped ha hecho checkout</summary>
            Finished, //
            /// <summary>la reserva se canceló </summary>
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
