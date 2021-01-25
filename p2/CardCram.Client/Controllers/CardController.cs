
using Microsoft.AspNetCore.Mvc;

namespace CardCram.Client.Controllers
{
    public class CardController : Controller
    {
        [Route("[controller]/[action]")]

        [HttpPost]
        public IActionResult CreateDeck()
        {
            return View ();
        }

        [HttpPost]
        public IActionResult AddCard()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteCard()
        {
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