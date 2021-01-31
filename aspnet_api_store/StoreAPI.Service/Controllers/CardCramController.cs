using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreApi.Service.Models;

namespace StoreApi.Service.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CardCramController : ControllerBase
  {
    private CardCramContext _ctx = new CardCramContext();

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var chars = _ctx.Deck.FirstOrDefault();

      return await Task.FromResult(Ok(chars.Cards));

    }
  }
}