using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Business.Abstract;
using VrMarketim.DataAccess.Abstract;
using VrMarketim.Entities;

namespace VrMarketim.Business.Concrete
{
    public class BasketManager : IBasketService
    {
        private IBasketRepository _basketRepository;

        public BasketManager(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }
        public Basket CreateBasket(Basket basket)
        {
            if (_basketRepository.GetBasket(basket.AccountId).AccountId != basket.AccountId)
            {
                _basketRepository.CreateBasket(basket);
                return basket;
            }
            else
            {
                return new Basket();
            }
        }

        public Basket GetBasket(int accountId)
        {
            return _basketRepository.GetBasket(accountId);
        }
    }
}
