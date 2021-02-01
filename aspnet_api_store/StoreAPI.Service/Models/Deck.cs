using System.Collections.Generic;

namespace StoreAPI.Service.Models
{
  public class Deck
  {
    public int EntityId { get; set; }
    public List<Card> Cards  { get; set; }
  }
}