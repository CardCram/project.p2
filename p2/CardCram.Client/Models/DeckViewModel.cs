using System.Collections.Generic;
using CardCram.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CardCram.Client.Models
{
    public class DeckViewModel
    {
      public List<Card> Cards { get; set; }
      public Card NewCard { get; set; }
      public int DeckId { get; set; }
      public string Title { get; set; }

      public DeckViewModel() {
        Cards = new List<Card>();
      }
    }
}