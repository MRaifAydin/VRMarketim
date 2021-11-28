using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.DataAccess.Abstract;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess.Concrete
{
    public class BasketRepository : IBasketRepository
    {
        public Basket CreateBasket(Basket basket)
        {
            using (var databaseContext = new DatabaseContext())
            {
                databaseContext.Baskets.Add(basket);
                databaseContext.SaveChanges();
                return basket;
            }
        }

        public Basket GetBasket(int accountId)
        {
            using (var databaseContext = new DatabaseContext())
            {
                var basket = databaseContext.Baskets.FirstOrDefault(b => b.AccountId == accountId);
                if (basket == null)
                {
                    return new Basket();
                }
                else { return basket; }
            }
        }
    }
}
