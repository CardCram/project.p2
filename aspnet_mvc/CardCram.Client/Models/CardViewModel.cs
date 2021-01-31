using Microsoft.Extensions.Configuration;
namespace CardCram.Client.Models
{
    public class CardViewModel
  {
    public int CardId { get; set; }
    public int DeckId { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public DeckViewModel Deck {get; set; }   
  }
}