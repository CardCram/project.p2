using System.Collections.Generic;

namespace CardCram.Domain.Models
{
  public class Deck
  {
    public int EntityId { get; set; }
    public List<Card> Cards  { get; set; }
  }
}