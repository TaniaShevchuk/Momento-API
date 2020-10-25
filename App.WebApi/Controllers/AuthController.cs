using App.Domain;
using App.DomainContract;
using App.WebApi.ViewModels;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace App.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        [Route("auth")]
        public IActionResult Authenticate([FromServices] IAuthSvc authSvc, [FromQuery] UserAuthentication user)
        {
            var response = authSvc.AuthenticateUser(user.Email, user.Password);

            return Ok(response);
        }
    }
}
