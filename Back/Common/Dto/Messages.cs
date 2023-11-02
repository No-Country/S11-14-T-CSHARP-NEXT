namespace HotelWiz.Back.Common.Dto
{
    public class Message
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool HasAttachment { get; set; }
        public DateTime ReceivedBy { get; set; }
        public bool IsReaded { get; set; }
        public string Origin { get; set; }
    }

    public enum MessageOrigins
    {
        Email,
        Form,
        Whatsapp,
        Instagram,
    }
}
