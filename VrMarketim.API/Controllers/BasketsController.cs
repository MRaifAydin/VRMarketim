using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrMarketim.Business.Abstract;
using VrMarketim.Entities;

namespace VrMarketim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private IBasketService _basketService;

        public BasketsController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet("{accountId}")]
        public Basket GetBasket(int accountId)
        {
            return _basketService.GetBasket(accountId);
        }

        [HttpPost]
        public Basket Createbasket(Basket basket)
        {
            return _basketService.CreateBasket(basket);
        }

        [HttpDelete("{accountId}/{itemId}")]
        public bool DeleteBasketItem(int accountId, String itemId)
        {
            return _basketService.DeleteBasketItem(accountId, itemId);
        }

        [HttpGet("{accountId}/{itemId}")]
        public GeneralProduct GetBasketItem(int accountId, String itemId)
        {
            return _basketService.GetBasketItem(accountId, itemId);
        }

        [Route("getAllBasket/{accountId}")]
        [HttpGet]
        public List<GeneralProduct> GetAllBasket(int accountId)
        {
            return _basketService.GetAllBasket(accountId);
        }
    }
}
