﻿using HotelWiz.Back.Common.Enums;
using HotelWiz.Back.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.CodeDom;

namespace HotelWiz.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        //TODO move to service
        private readonly Contexto _contexto;
        public IssuesController(Contexto contexto)
        {
            _contexto = contexto;
        }



        [HttpGet("statuses")]
        public IEnumerable<object> Statuses() =>
            Enum.GetNames(typeof(IssueType)).Select((x, index) =>
            new
            {
                value = index,
                text = x.ToString()

            });

        [HttpPost("{issuedId:int}")]
        //[Authorize]
        public ActionResult<bool> ChangeIssueStatus(int issuedId, IssueType newIssueType)
        {
            var issue = _contexto.Issues.FirstOrDefault(x => x.IssueId == issuedId);
            if (issue == null)
            {
                return NotFound();
            }

            issue.Status = newIssueType.ToString();
            try
            {
                _contexto.Entry(issue).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _contexto.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

    }
}
