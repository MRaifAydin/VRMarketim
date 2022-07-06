using Microsoft.AspNetCore.Mvc;
using VrMarketim.Business.Abstract;
using VrMarketim.Entities;

namespace VrMarketim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpPost]
        public bool Post([FromBody] Card _card)
        {
            return _cardService.CreateCard(_card);
        }
    }
}
