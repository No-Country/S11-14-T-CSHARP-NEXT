using Microsoft.EntityFrameworkCore;
using S11.Common.Dto;
using S11.Common.Enums;
using S11.Data;
using S11.Data.Models;

namespace S11.Services
{
    public class IssuesService
    {
        //TODO pagedList
        //TODO Filter

        private readonly Contexto _contexto;
        public IssuesService(Contexto contexto)
        {
            _contexto = contexto;
        }

        /// <summary>  Obtiene el resumen de las incidencias con las [nItems] primeras ordenadas por fecha </summary>
        /// <returns></returns>
        public async Task<IssuesResumeDto> GetResume(int nItems = 10)
        {
            var data = _contexto.Issues
                //.OrderBy(x => x.DateIssue)
                ;

            var dto = new IssuesResumeDto()
            {
                //TODO mapper
                //Data = data.Take(nItems).Select(x => new IssueDto()
                //{
                //    Area = x.Area,
                //    Category = x.Category,
                //    Description = x.Description,
                //    Status = x.Status,
                //    DateIssue = x.DateIssue,
                //    RoomId = x.RoomId,
                //    GuestId = x.GuestId,
                //    IssueId = x.IssueId,
                //    ReportedBy = x.ReportedBy,
                //    Title = x.Title
                //}),
                //InProgress = data.Count(x => x.Status == IssueType.InProgress.ToString()),
                //ToDo = data.Count(x => x.Status == IssueType.ToDo.ToString()),
                //Done = data.Count(x => x.Status == IssueType.Done.ToString()),
                //Total = data.Count()
            };

            var dto2 = await data.GroupBy(x => x.Status).Select(x => new { Status = x.Key, Count = x.Count() }).ToListAsync();
            var res = new IssuesResumeDto()
            {
                InProgress = dto2.FirstOrDefault(x => x.Status == nameof(IssueType.InProgress))?.Count ?? 0,
                ToDo = dto2.FirstOrDefault(x => x.Status == nameof(IssueType.ToDo))?.Count ?? 0,
                Done = dto2.FirstOrDefault(x => x.Status == nameof(IssueType.Done))?.Count ?? 0
            };

            return res;
        }

        [Obsolete("No para este sprint", error: true)]
        public Issue CreateNew(IssueDto incidencia)
        {
            var model = new Issue()
            {
                Area = incidencia.Area,
                Category = incidencia.Category,
                Description = incidencia.Description,
                Status = incidencia.Status,
                DateIssue = incidencia.DateIssue,
                RoomId = incidencia.RoomId,
                GuestId = incidencia.GuestId,
                IssueId = incidencia.IssueId,
                ReportedBy = incidencia.ReportedBy,
                Title = incidencia.Title
            };

            try
            {
                _contexto.Issues.Add(model);
                _contexto.SaveChanges();
                return model;
            }
            catch (Exception e)
            {
                //log
                throw;
            }
        }

        [Obsolete("No para este sprint", error: true)]
        public List<IssueDto> GetAll()
        {
            var data = _contexto.Issues.ToList();
            var dtos = data.Select(x => new IssueDto()
            {
                Area = x.Area,
                Category = x.Category,
                Description = x.Description,
                Status = x.Status,
                DateIssue = x.DateIssue,
                RoomId = x.RoomId,
                GuestId = x.GuestId,
                IssueId = x.IssueId,
                ReportedBy = x.ReportedBy,
                Title = x.Title
            }).ToList();

            return dtos;
        }
    }
}

