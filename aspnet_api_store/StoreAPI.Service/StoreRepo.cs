using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Service.Models;

namespace StoreAPI.Service
{
    public class StoreRepo
    {
        private CardCramContext _stx;
        public StoreRepo(CardCramContext context)
        {
            _stx = context;
        }

        public List<string> CreateCard()
        {
            return _stx.Card.Select(c => c.Question).ToList();
        }

        public List<string> CreateDeck()
        {
            return _stx.Deck.Select(d => d.Name).ToList();
        }

        public DbSet<Deck> GetDeck()
        {
            return _stx.Deck;
        }

        public List<string> DeleteCard()
        {
            return _stx.Card.Select(c => c.Question).ToList();
        }

        public void DeleteDeck(Deck target)
        {
            _stx.Deck.Remove(target);
        }
    }
}

