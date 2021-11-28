using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrMarketim.Business.Abstract;
using VrMarketim.Business.Concrete;
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
        public bool Post([FromBody] Account account)
        {
            return _accountService.CreateUser(account);
        }

        [Route("checkUser")]
        [HttpPost]
        public bool CheckUser([FromBody] Account account)
        {
            return _accountService.CheckUser(account);
        }

        [HttpPut]
        public Account UpdateUser([FromBody] Account account)
        {
            return _accountService.UpdateUser(account);
        }
    }
}
