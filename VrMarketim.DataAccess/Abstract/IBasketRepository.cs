using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess.Abstract
{
    public interface IBasketRepository
    {
        Basket GetBasket(int accountId);

        List<GeneralProduct> GetAllBasket(int accountId);

        Basket CreateBasket(Basket basket);

        GeneralProduct GetBasketItem(int accountId, string itemId);

        bool DeleteBasketItem(int accountId, string itemId);
    }
}
