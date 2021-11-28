using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Business.Abstract;
using VrMarketim.DataAccess.Abstract;

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

        public GeneralProduct CreateProduct(GeneralProduct generalProduct)
        {
            return _generalProductRepository.CreateProduct(generalProduct);
        }

        public void DeleteProduct(int id)
        {
            _generalProductRepository.DeleteProduct(id);
        }

        public List<GeneralProduct> GetAllProducts()
        {
            return _generalProductRepository.GetAllProducts();
        }

        public GeneralProduct GetProductById(int id)
        {
            return _generalProductRepository.GetProductById(id);
        }

        public GeneralProduct UpdateProduct(GeneralProduct generalProduct)
        {
            return _generalProductRepository.UpdateProduct(generalProduct);
        }
    }
}
