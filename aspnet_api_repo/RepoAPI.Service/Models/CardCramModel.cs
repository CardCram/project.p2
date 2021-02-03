using System.Collections.Generic;

namespace RepoAPI.Service.Models
{
    public class CardCramModel
    {
        public int EntityId { get; set; }
        public List<Card> Cards  { get; set; }
        public string Name {get; set;}
    }
}