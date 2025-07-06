using LibrarySystem.Application.DTOs;
using LibrarySystem.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IUserService userService) : ControllerBase
    {
        public readonly IUserService _userService = userService;
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAll()
        {
            return Ok(await _userService.GetAllAsync());
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> Create(CreateUserRequest request)
        {
            var created = await _userService.CreateAsync(request);
            return CreatedAtAction(nameof(GetAll), new { Id = created.Id }, created);
        }
    }
}
