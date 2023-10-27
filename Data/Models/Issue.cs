using System.ComponentModel.DataAnnotations;

namespace S11.Data.Models;

public class Issue
{
    [Key]
    public int IssueId { get; set; }
    public DateTime DateIssue { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    //FK
    public int ReportedBy { get; set; }
    public string Area { get; set; }
    //fk
    public string RoomId { get; set; }
    //fk
    public int GuestId { get; set; }
    //fk or seed
    public int Category { get; set; }
    public string Status { get; set; }


    //public string[] Imagenes { get; set; }
    //public string[] Videos { get; set; }
}
