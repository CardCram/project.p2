using System.Net.Http;
using System.Threading.Tasks;
using CardCram.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CardCram.Client.Controllers
{
    public class CardController : Controller
    {
        public string apiUrl = "https://localhost:5551/CardCram";

        private HttpClient _http = new HttpClient();

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _http.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = JsonConvert.DeserializeObject<CardViewModel>(await response.Content.ReadAsStringAsync());
                return View("CreateCard", content);
            }

            var ErrorViewModel = new ErrorViewModel();
            return View ("Error", ErrorViewModel);
        
            
        }

        [HttpGet]
        public IActionResult DeleteCard()
        {
            return View ("DeleteCard", new DeckViewModel());
        }
    }
}