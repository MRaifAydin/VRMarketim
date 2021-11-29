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
    public class PurchaseManager : IPurchaseService
    {
        private IPurchaseRepository _purchaseRepository;

        public PurchaseManager(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        public Purchase CreatePurchase(Purchase purchase)
        {
            return _purchaseRepository.CreatePurchase(purchase);
        }

        public Purchase GetPurchase(int id)
        {
            return _purchaseRepository.GetPurchase(id);
        }
    }
}
