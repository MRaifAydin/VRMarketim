using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Business.Abstract;
using VrMarketim.DataAccess.Abstract;
using VrMarketim.Dto.Conversion;
using VrMarketim.Dto.Dto;
using VrMarketim.Entities;

namespace VrMarketim.Business.Concrete
{
    public class GeneralProductManager : IGeneralProductService
    {
        private IGeneralProductRepository _generalProductRepository;

        public GeneralProductManager(IGeneralProductRepository generalProductRepository)
        {
            _generalProductRepository = generalProductRepository;
        }

        public GeneralProductDto CreateProduct(GeneralProductDto generalProduct)
        {
            return _generalProductRepository.CreateProduct(GeneralProductConversion.ToEntity(generalProduct));
        }

        public void DeleteProduct(int id)
        {
            _generalProductRepository.DeleteProduct(id);
        }

        public List<GeneralProduct> GetAllProducts()
        {
            return _generalProductRepository.GetAllProducts();
        }

        public GeneralProductDto GetProductById(int id)
        {
            return _generalProductRepository.GetProductById(id);
        }

        public GeneralProductDto UpdateProduct(GeneralProductDto generalProduct)
        {
            return _generalProductRepository.UpdateProduct(GeneralProductConversion.ToEntity(generalProduct));
        }
    }
}
