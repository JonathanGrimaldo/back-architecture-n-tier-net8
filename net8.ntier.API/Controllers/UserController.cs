using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using net8.ntier.API.Dtos.Users;
using net8.ntier.Domain.Entities;
using net8.ntier.Domain.Services;

namespace net8.ntier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        //TODO: Add responses minimal
        [HttpGet]
        public async Task<IActionResult> GetByName([FromQuery] string name)
        {
            var users = await _userService.GetByName(name);
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            var user = await _userService.GetByIdAsync(id, cancellationToken);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] UserCreateRequest request , CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<UserCreateRequest, User>(request); //todo: add hashing

            await _userService.AddAsync(entity, cancellationToken);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] UserUpdateRequest request, CancellationToken cancellationToken)
        {
            var existingUser = await _userService.GetByIdAsync(id, cancellationToken);
            if (existingUser == null)
            {
                return NotFound();
            }

            _mapper.Map(request, existingUser);
            _userService.Update(existingUser);

            return Ok(existingUser);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var existingUser = await _userService.GetByIdAsync(id, cancellationToken);
            if (existingUser == null)
            {
                return NotFound();
            }
            _userService.Delete(existingUser);
            return NoContent();
        }
    }
}
