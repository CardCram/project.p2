using System;
using CardCram.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace CardCram.Client.Controllers
{
    public class CardController : Controller
    {
        CardViewModel NewCard = new CardViewModel();
        DeckViewModel CardList = new DeckViewModel();
        [Route("[controller]/[action]")]

        [HttpPost]
        public IActionResult CreateDeck()
        {

            
            return View ();
        }

        [HttpPost]
        public IActionResult AddCard()
        {
            String Answer = NewCard.Answer;
            String Question = NewCard.Question;
            if(CardList is null)
            {
                CardList.Cards.Add(NewCard);
                ViewData["CardList"] = CardList;
            }

            else
            {
                ViewData["CardList"] = CardList;
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult DeleteCard()
        {
            CardList.Cards.Remove(NewCard);
            return View();
        }

        [HttpPost]

        public IActionResult DeleteDeck()
        {
            return View();
        }

        public IActionResult DownloadDeck()
        {
            return View();

        
        }


        
        
            
    }
}
