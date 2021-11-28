using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess.Abstract
{
    public interface IGeneralProductRepository
    {
        List<GeneralProduct> GetAllProducts();
        GeneralProduct GetProductById(int id);
        GeneralProduct CreateProduct(GeneralProduct generalProduct);
        GeneralProduct UpdateProduct(GeneralProduct generalProduct);
        void DeleteProduct(int id);
    }
}
