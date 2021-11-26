using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrMarketim.Business.Abstract;
using VrMarketim.Business.Concrete;
using VrMarketim.Dto.Dto;
using VrMarketim.Entities;

namespace VrMarketim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public bool Post([FromBody] AccountDto account)
        {
            return _accountService.CreateUser(account);
        }

        [Route("checkUser")]
        [HttpPost]
        public bool CheckUser([FromBody] AccountDto account)
        {
            return _accountService.CheckUser(account);
        }
    }
}
