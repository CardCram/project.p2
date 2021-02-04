namespace CardCram.Client.Models
{
    public class CardViewModel
  {
    public string Question { get; set; }
    public string Answer { get; set; }  

    public DeckViewModel Deck {get; set;}

    public int CardId {get; set;}

    public int DeckId {get; set;}
  }
}