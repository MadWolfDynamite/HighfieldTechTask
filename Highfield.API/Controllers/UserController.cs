using Highfield.Domain.Contracts;
using Highfield.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Highfield.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ResponseDTO> GetAllUserData()
        {
            var serviceResponse = await _userService.GetUserDataAsync();
            return serviceResponse;
        }
    }
}
