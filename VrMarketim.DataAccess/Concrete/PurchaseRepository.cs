using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.DataAccess.Abstract;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess.Concrete
{
    public class PurchaseRepository : IPurchaseRepository
    {
        public Purchase CreatePurchase(Purchase purchase)
        {
            using (var databaseContext = new DatabaseContext())
            {
                databaseContext.Purchases.Add(purchase);
                databaseContext.SaveChanges();
                return purchase;
            }
        }

        public Purchase GetPurchase(int id)
        {
            using (var databaseContext = new DatabaseContext())
            {
                var purchase = databaseContext.Purchases.FirstOrDefault(purchase => purchase.Id == id);
                if (purchase == null)
                {
                    return new Purchase();
                }
                else { return purchase; }
            }
        }
    }
}
