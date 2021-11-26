using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.DataAccess.Abstract;
using VrMarketim.Dto.Conversion;
using VrMarketim.Dto.Dto;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess.Concrete
{
    public class GeneralProductRepository : IGeneralProductRepository
    {
        public GeneralProductDto CreateProduct(GeneralProduct generalProduct)
        {
            using (var databaseContext = new DatabaseContext())
            {
                databaseContext.GeneralProducts.Add(generalProduct);
                databaseContext.SaveChanges();
                return GeneralProductConversion.ToApi(generalProduct);
            }
        }

        public void DeleteProduct(int id)
        {
            using (var databaseContext = new DatabaseContext())
            {
                var deletedProduct = GetProductById(id);
                databaseContext.GeneralProducts.Remove(GeneralProductConversion.ToEntity(deletedProduct));
                databaseContext.SaveChanges();
            }
        }

        public List<GeneralProduct> GetAllProducts()
        {
            using (var databaseContext = new DatabaseContext())
            {
                return databaseContext.GeneralProducts.ToList();

            }
        }

        public GeneralProductDto GetProductById(int id)
        {
            using (var databaseContext = new DatabaseContext())
            {
                return GeneralProductConversion.ToApi(databaseContext.GeneralProducts.Find(id));
            }
        }

        public GeneralProductDto UpdateProduct(GeneralProduct generalProduct)
        {
            using (var databaseContext = new DatabaseContext())
            {
                databaseContext.GeneralProducts.Update(generalProduct);
                databaseContext.SaveChanges();
                return GeneralProductConversion.ToApi(generalProduct);
            }
        }
    }
}
