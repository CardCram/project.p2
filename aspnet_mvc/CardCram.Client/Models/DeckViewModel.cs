using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace CardCram.Client.Models
{
  public class DeckViewModel
  {
    public List<CardViewModel> Cards { get; set; }
    public CardViewModel NewCard { get; set; }
    public int DeckId { get; set; }
    public string Title { get; set; }
    public DeckViewModel() {
      Cards = new List<CardViewModel>();
      }
    }
}