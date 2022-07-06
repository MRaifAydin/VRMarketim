using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.DataAccess.Abstract;
using VrMarketim.Entities;

namespace VrMarketim.DataAccess.Concrete
{
    public class CardRepository : ICardRepository
    {
        public Card CreateCard(Card card)
        {
            using (var databaseContext = new DatabaseContext())
            {
                databaseContext.Cards.Add(card);
                databaseContext.SaveChanges();
                return card;
            }
        }
    }
}
