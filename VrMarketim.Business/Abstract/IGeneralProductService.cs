using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Entities;

namespace VrMarketim.Business.Abstract
{
    public interface IGeneralProductService
    {
        List<GeneralProduct> GetAllProducts();
        GeneralProduct GetProductById(int id);
        GeneralProduct CreateProduct(GeneralProduct generalProduct);
        GeneralProduct UpdateProduct(GeneralProduct generalProduct);
        void DeleteProduct(int id);
    }
}
