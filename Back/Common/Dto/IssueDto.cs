using System.ComponentModel.DataAnnotations;

namespace HotelWiz.Back.Common.Dto
{
    public class IssueDto
    {
        public int IssueId { get; set; }
        public DateTime DateIssue { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReportedBy { get; set; }
        public string Area { get; set; }
        public string RoomId { get; set; }
        public int GuestId { get; set; }
        public int Category { get; set; }
        public string Status { get; set; }
    }
}
