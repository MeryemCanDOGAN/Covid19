using System.Buffers;
using Microsoft.AspNetCore.Mvc;

namespace CovidApp
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("create")]
        public async Task Create(Account account)
        {
            await _accountService.Create(account);
        }

        [HttpPut("update")]
        public async Task Update(Account account)
        {
            await _accountService.Update(account);
        }

        [HttpPost("updatephonenumber")]
        public async Task UpdatePhoneNumber(string oldPhoneNumber, string newPhoneNumber)
        {
            await _accountService.UpdatePhoneNumber(oldPhoneNumber, newPhoneNumber);
        }

        [HttpPost("changeisblocked")]
        public async Task ChangeIsBlockedById([FromQuery] int id)
        {
            await _accountService.ChangeIsBlockedById(id);
        }

        [HttpPost("changevisibility")]
        public async Task ChangeVisibilityById([FromQuery] int id)
        {
            await _accountService.ChangeVisibilityById(id);
        }

        [HttpDelete("delete")]
        public async Task DeleteById([FromQuery] int id)
        {
            await _accountService.Delete(id);
        }

        [HttpGet("getall")]
        public async Task<List<Account>> GetAll()
        {
            return await _accountService.GetAll();
        }

        [HttpGet("getbyphonenumber")]
        public async Task<Account> GetByPhoneNumber([FromQuery] string phoneNumber)
        {
            return await _accountService.FindByPhoneNumber(phoneNumber);
        }

        [HttpGet("getbyid")]
        public async Task<Account> GetById([FromQuery] int id)
        {
            return await _accountService.FindById(id);
        }

        [HttpGet("getallbyblocked")]
        public async Task<List<Account>> GetAllByBlocked([FromQuery] bool isBlocked)
        {
            return await _accountService.GetAllByBlocked(isBlocked);
        }

        [HttpGet("getallbyvisibility")]
        public async Task<List<Account>> GetAllByVisibility([FromQuery] bool isVisible)
        {
            return await _accountService.GetAllByVisibility(isVisible);
        }

    }
}