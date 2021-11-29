using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Entities;

namespace VrMarketim.Business.Abstract
{
    public interface IPurchaseService
    {
        Purchase GetPurchase(int id);

        Purchase CreatePurchase(Purchase purchase);
    }
}
