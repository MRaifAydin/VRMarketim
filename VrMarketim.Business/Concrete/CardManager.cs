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
    public class CardManager : ICardService
    {
        private ICardRepository _cardRepository;

        public CardManager(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public bool CreateCard(Card card)
        {
            Card _card = new Card();
            _card.CardNumber = card.CardNumber;
            _card.NameSurname = card.NameSurname;
            _card.Date = card.Date;
            _card.SecCode = card.SecCode;

            _cardRepository.CreateCard(card);
            return true;
        }
    }
}
