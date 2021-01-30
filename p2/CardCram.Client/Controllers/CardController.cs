using System;
using CardCram.Client.Models;
using CardCram.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CardCram.Client.Controllers
{
    public class CardController : Controller
    {
        Card NewCard = new Card();
        DeckViewModel CardList = new DeckViewModel();
        [Route("[controller]/[action]")]

        [HttpGet]
        public IActionResult AddCard()
        {
            return View("create", CardList);
        }

        [HttpGet]
        public IActionResult DeleteCard()
        {
            return View("delete", CardList);
        }

        [HttpGet]
        public IActionResult Create(DeckViewModel model)
        {
            CardList.Cards.Add(model.NewCard);
            return View("viewcards", CardList);
        }

        [HttpGet]
        public IActionResult ViewCards()
        {
            return View("viewcards", CardList);
        }
    }
}
