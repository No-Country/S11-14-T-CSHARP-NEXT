using HotelWiz.Common.Dto.Dashboard;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using S11.Services;

namespace HotelWiz.Services
{
    public class DashboardService
    {
        private readonly IssuesService _issuesService;
        private readonly RoomService _roomService;
        private readonly ReservationsService _resertvationsService;

        public DashboardService(IssuesService issuesService, RoomService roomService, ReservationsService reservationsService)
        {
            _issuesService = issuesService;
            _roomService = roomService;
            _resertvationsService = reservationsService;
        }

        public TempDashBoardResponse GetDashboardBoardResponse()
        {
            //TODO refactor
            var dashBoardreport = new TempDashBoardResponse();
            dashBoardreport.Issues = _issuesService.GetResume();
            dashBoardreport.Rooms = _roomService.GetResume();
            dashBoardreport.Reservations = _resertvationsService.GetResume();

            return dashBoardreport;
        }
    }
}
