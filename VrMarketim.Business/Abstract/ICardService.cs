using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Entities;

namespace VrMarketim.Business.Abstract
{
    public interface ICardService
    {
        public bool CreateCard(Card card);
    }
}
