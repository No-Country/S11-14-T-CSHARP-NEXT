using HotelWiz.Back.Common.Dto.Auth;
using HotelWiz.Back.Common.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelWiz.Back.Controllers
{

    public class AuthController : BaseApiController
    {

        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        //TODO definir que devuelve + un error de validacion
        [HttpPost(nameof(Login))]
        public async Task<ActionResult<LoginResponseDto>> Login(LoginPostDto login)
        {
            //userName
            //rol
            await _authService.CreateTestUsers();
            var res = await _authService.Login(login.UserName, login.Password);
            if (!res.IsValid) return BadRequest(res);
            return res;
            //token
        }

        [HttpPost(nameof(RestorePassword))]
        public ActionResult RestorePassword(string userName)
        {
            _authService.RestorePassword(userName);
            return Ok();
        }

        [Obsolete(message: "not implemented yet")]
        [HttpPost(nameof(ChangePassword))]
        public ActionResult ChangePassword(string userName, string password, string token)
        {
            throw new NotImplementedException();
        }

        [HttpGet(nameof(TestAuthorize))]
        [Authorize]
        public IActionResult TestAuthorize()
        { return Ok(); }
    }
}
