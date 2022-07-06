using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess.Abstract
{
    public interface ICardRepository
    {
        public Card CreateCard(Card card);

    }
}
