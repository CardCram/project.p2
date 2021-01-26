using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace CardCram.Client.Models
{
    public class DeckViewModel
    {
      public List<CardViewModel> Cards { get; set; }

    }
}