using Microsoft.AspNetCore.Mvc;
using Whiskyfy_Api.ApplicationServices.Contracts;

namespace Whiskyfy_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserManagmentController : ControllerBase
    {

        private readonly ILogger<UserManagmentController> _logger;
        private readonly IUserManagmentAppServices _userManagmentAppServices;

        public UserManagmentController(ILogger<UserManagmentController> logger, IUserManagmentAppServices userManagmentAppServices)
        {
            _logger = logger;
            _userManagmentAppServices = userManagmentAppServices;
        }

        [HttpGet(Name = "login")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}