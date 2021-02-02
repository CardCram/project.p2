using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StoreAPI.Service
{
    public class StoreRepo
    {
        private StoreRepoContext _stx;
        public StoreRepo(StoreRepoContext context)
        {
            _stx = context;
        }

        public List<string> CreateCard()
        {
            return _stx.Cards.Select(c => c.Name).ToList();
        }

        public List<string> CreateDeck()
        {
            return _stx.Decks.Select(d => d.Name).ToList();
        }

        public List<string> GetDeck()
        {
            return _stx.Decks;
        }

        public List<string> DeleteCard()
        {
            return _stx.Cards.Select(c => c.Name).ToList();
        }

        public List<string> DeleteDeck()
        {
            _stx.Decks.Remove(Deck);
        }
    }
}

