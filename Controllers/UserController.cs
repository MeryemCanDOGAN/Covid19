using System.Buffers;
using Microsoft.AspNetCore.Mvc;

namespace CovidApp
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("create")]
        public async Task Create(User user)
        {
            await _userService.Create(user);
        }

        [HttpPut("update")]
        public async Task Update(User user)
        {
            await _userService.Update(user);
        }

        [HttpDelete("delete")]
        public async Task Delete(User user)
        {
            await _userService.Delete(user);
        }

        [HttpGet("getall")]
        public async Task<List<User>> GetAll()
        {
            return await _userService.GetAll();
        }

        [HttpGet]
        public async Task<User> FindById([FromQuery]int id)
        {
            return await _userService.FindById(id);
        }

        [HttpGet("positivecount")]
        public async Task<int> PositiveCount()
        {
            return await _userService.CoronaCount();
        }

        [HttpGet("positivecountbycity")]
        public async Task<int> PositiveCountByCity([FromQuery]int plateCode)
        {
            return await _userService.CoronaCountByCity(plateCode);
        }

        [HttpGet("getallbycity")]
        public async Task<List<User>> GetAllByCity([FromQuery]int plateCode)
        {
            return await _userService.GetAllUserByCityFromPlateCode(plateCode);
        }

        [HttpGet("getallpositives")]
        public async Task<List<User>> GetAllPositiveUser()
        {
            return await _userService.GetAllByIsCorona(true);
        }

        [HttpGet("getallpositivesbycity")]
        public async Task<List<User>> GetAllPositiveUserByCityPlateCode([FromQuery]int plateCode)
        {
            return await _userService.GetAllByCityPlateCodeAndIsCorona(plateCode,true);
        }
    }
}