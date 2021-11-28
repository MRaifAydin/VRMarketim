using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.DataAccess.Abstract;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess.Concrete
{
    public class GeneralProductRepository : IGeneralProductRepository
    {
        public GeneralProduct CreateProduct(GeneralProduct generalProduct)
        {
            using (var databaseContext = new DatabaseContext())
            {
                databaseContext.GeneralProducts.Add(generalProduct);
                databaseContext.SaveChanges();
                return generalProduct;
            }
        }

        public void DeleteProduct(int id)
        {
            using (var databaseContext = new DatabaseContext())
            {
                var deletedProduct = GetProductById(id);
                databaseContext.GeneralProducts.Remove(deletedProduct);
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

        public GeneralProduct GetProductById(int id)
        {
            using (var databaseContext = new DatabaseContext())
            {
                return databaseContext.GeneralProducts.Find(id);
            }
        }

        public GeneralProduct UpdateProduct(GeneralProduct generalProduct)
        {
            using (var databaseContext = new DatabaseContext())
            {
                databaseContext.GeneralProducts.Update(generalProduct);
                databaseContext.SaveChanges();
                return generalProduct;
            }
        }
    }
}
