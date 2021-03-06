using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrMarketim.MailService;

namespace VrMarketim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailSender _mailSender;

        public MailController(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var message = new Message(new string[] { "mert5708@gmail.com" }, "Test Mail Async", "Content");
            await _mailSender.SendMailAsync(message);
            return "Mail Sent.";
        }

    }
}
