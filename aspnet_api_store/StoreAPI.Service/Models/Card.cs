namespace StoreAPI.Service.Models
{
  public class Card
  {
    public int EntityId { get; set; }
    public string Question { get; set; }
    public string Answer {get; set;}

    public Deck Deck {get; set;}
    public int DeckEntityId {get; set;}
  }
}