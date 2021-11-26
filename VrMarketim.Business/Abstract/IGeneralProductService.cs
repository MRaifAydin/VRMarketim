using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Dto.Dto;
using VrMarketim.Entities;

namespace VrMarketim.Business.Abstract
{
    public interface IGeneralProductService
    {
        List<GeneralProduct> GetAllProducts();
        GeneralProductDto GetProductById(int id);
        GeneralProductDto CreateProduct(GeneralProductDto generalProduct);
        GeneralProductDto UpdateProduct(GeneralProductDto generalProduct);
        void DeleteProduct(int id);
    }
}
