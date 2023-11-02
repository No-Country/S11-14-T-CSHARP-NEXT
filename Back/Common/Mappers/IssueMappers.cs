using HotelWiz.Back.Common.Dto;
using HotelWiz.Back.Data.Models;

namespace HotelWiz.Back.Common.Mappers
{
    public static class IssueMappers
    {
        public static IList<IssueDto> MapperIssueToDto(this IEnumerable<Issue> issues)
        {
            var dtos = new List<IssueDto>();
            foreach (var item in issues)
            {
                dtos.Add(
                    new IssueDto
                    {
                        DateIssue = item.DateIssue,
                        RoomId = item.RoomId,
                        Area = item.Area,
                        Category = item.Category,
                        Description = item.Description,
                        GuestId = item.GuestId,
                        IssueId = item.IssueId,
                        ReportedBy = item.ReportedBy,
                        Status = item.Status,
                        Title = item.Title
                    });
            }
            return dtos;
        }
    }
}
