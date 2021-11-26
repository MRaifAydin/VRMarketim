using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrMarketim.Business.Abstract;
using VrMarketim.Dto.Dto;
using VrMarketim.Entities;

namespace VrMarketim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IGeneralProductService _generalProductService;

        public ProductsController(IGeneralProductService generalProductService)
        {
            _generalProductService = generalProductService;
        }

        [HttpGet]
        public List<GeneralProduct> Get()
        {
            return _generalProductService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public GeneralProductDto Get(int id)
        {
            return _generalProductService.GetProductById(id);
        }

        [HttpPost]
        public GeneralProductDto Post([FromBody]GeneralProductDto product)
        {
            return _generalProductService.CreateProduct(product);
        }

        [HttpPut]
        public GeneralProductDto Put([FromBody]GeneralProductDto product)
        {
            return _generalProductService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            _generalProductService.DeleteProduct(id);
        }
    }
}
