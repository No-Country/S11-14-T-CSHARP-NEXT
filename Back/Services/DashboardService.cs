using HotelWiz.Back.Common.Dto.Dashboard;
using HotelWiz.Back.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HotelWiz.Back.Services
{
    public class DashboardService
    {
        private readonly IssuesService _issuesService;
        private readonly RoomService _roomService;
        private readonly ReservationsService _resertvationsService;

        public DashboardService(Contexto contexto, IssuesService issuesService, RoomService roomService, ReservationsService reservationsService)
        {
            //_issuesService = new IssuesService(contexto);
            //_roomService = new RoomService(contexto);
            //_resertvationsService = new ReservationsService(contexto);       
            _issuesService = issuesService;
            _roomService = roomService;
            _resertvationsService = reservationsService;
        }

        public async Task<TempDashBoardResponse> GetDashboardBoardResponse()
        {
            //TODO refactor
            var dashBoardreport = new TempDashBoardResponse();
            var t1 = _issuesService.GetResume();
            var t2 = _roomService.GetResume();
            var t3 = _resertvationsService.GetResume();

            await Task.WhenAll(t1, t2, t3);
            dashBoardreport.Issues = t1.Result;
            dashBoardreport.Rooms = t2.Result;
            dashBoardreport.Reservations = t3.Result;
            //dashBoardreport.Rooms = _roomService.GetResume();
            //dashBoardreport.Reservations = _resertvationsService.GetResume();

            return dashBoardreport;
        }
    }
}
