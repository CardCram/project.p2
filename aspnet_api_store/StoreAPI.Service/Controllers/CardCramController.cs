using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreAPI.Service.Models;
using StoreAPI.Service;

namespace StoreAPI.Service.Controllers
{
  [ApiController]
  [Route("api")]
  public class CardCramController : ControllerBase
  {
    private readonly ILogger<CardCramController> _logger;
    private readonly CardCramContext _ctx;

    public CardCramController(ILogger<CardCramController> logger, CardCramContext context) 
    {
      _logger = logger;
      _ctx = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var deck = _ctx.Deck.FirstOrDefault();
      var Card = new Card();
      Card.Question = "1x1";
      Card.Answer = "1";
      Card.EntityId = 1; 
      Card.DeckEntityId = 1;
      deck.Cards = new List<Card>();
      deck.Cards.Add(Card);
      return await Task.FromResult(Ok(deck));

    }
  }
}