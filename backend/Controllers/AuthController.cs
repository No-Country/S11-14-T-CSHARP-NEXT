using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S11.Common.Dtos.Auth;
using S11.Common.Interfaces;

namespace S11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;
        public AuthController(IAuthService authService )
        {
            _authService = authService;
        }

        //TODO definir que devuelve + un error de validacion
        [HttpPost]
        public ActionResult<object> Login(LoginPostDto login)
        {
            //userName
            //rol
            //token
            return _authService.Login(login.UserName, login.Password);
        }

        [HttpPost]
        public ActionResult RestorePassword(string userName)
        {
            _authService.RestorePassword(userName);
            return Ok();
        }

        [HttpPost]
        public ActionResult ChangePassword(string userName,string password, string token)
        {
            throw new NotImplementedException();
        }
    }
}
