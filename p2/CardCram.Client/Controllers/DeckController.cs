using System;
using CardCram.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace CardCram.Client.Controllers
{
    public class DeckController : Controller
    {
        CardViewModel NewCard = new CardViewModel();
        DeckViewModel CardList = new DeckViewModel();
        [Route("[controller]/[action]")]

        [HttpGet]
        public IActionResult CreateDeck()
        {
            return View("create");
        }

        [HttpGet]
        public IActionResult DeleteDeck()
        {
            return View("delete");
        }

        public IActionResult DownloadDeck()
        {
            return View();
        }
    }
}
