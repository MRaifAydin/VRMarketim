using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrMarketim.Business.Abstract;
using VrMarketim.Entities;

namespace VrMarketim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private IPurchaseService _purchaseService;

        public PurchaseController(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        [HttpGet("{purchaseId}")]
        public Purchase GetPurchase(int purchaseId)
        {
            return _purchaseService.GetPurchase(purchaseId);
        }

        [HttpPost]
        public Purchase CreatePurchase(Purchase purchase)
        {
            return _purchaseService.CreatePurchase(purchase);
        }
    }
}
