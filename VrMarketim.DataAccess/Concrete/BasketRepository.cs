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

        public bool DeleteBasketItem(int accountId, string itemId)
        {
            using (var databaseContext = new DatabaseContext())
            {
                var item = GetBasketItem(accountId, itemId);
                if (item.Id != 0)
                {
                    var basket = GetBasket(accountId);
                    int itemIndex = basket.Products.IndexOf(itemId);

                    if (basket.Products.Length == 1)
                    {
                        basket.Products = basket.Products.Remove(itemIndex);
                    }
                    else if (itemIndex == basket.Products.Length - 1)
                    {
                        basket.Products = basket.Products.Remove(itemIndex - 1, 2);
                    }
                    else
                    {
                        basket.Products = basket.Products.Remove(itemIndex, 2);
                    }


                    databaseContext.Baskets.Update(basket);
                    databaseContext.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<GeneralProduct> GetAllBasket(int accountId)
        {

            using (var databaseContext = new DatabaseContext())
            {
                var instance = new GeneralProductRepository();
                List<GeneralProduct> basket = new List<GeneralProduct>();
                String[] basketContext = GetBasket(accountId).Products.Split(',');
                for (int i = 0; i < basketContext.Length; i++)
                {
                    var product = databaseContext.GeneralProducts.Find(Int32.Parse(basketContext[i]));
                    basket.Add(product);
                }
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



        public GeneralProduct GetBasketItem(int accountId, string itemId)
        {
            using (var databaseContext = new DatabaseContext())
            {
                string basket = GetBasket(accountId).Products;
                string[] items = basket.Split(',');
                if (items.Contains(itemId))
                {
                    return databaseContext.GeneralProducts.Find(Int32.Parse(itemId));
                }
                else { return new GeneralProduct(); }
            }
        }
    }
}
