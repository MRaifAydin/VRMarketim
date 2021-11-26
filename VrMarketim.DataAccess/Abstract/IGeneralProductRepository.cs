using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Dto.Dto;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess.Abstract
{
    public interface IGeneralProductRepository
    {
        List<GeneralProduct> GetAllProducts();
        GeneralProductDto GetProductById(int id);
        GeneralProductDto CreateProduct(GeneralProduct generalProduct);
        GeneralProductDto UpdateProduct(GeneralProduct generalProduct);
        void DeleteProduct(int id);
    }
}
