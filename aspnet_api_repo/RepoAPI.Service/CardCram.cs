using System;

namespace RepoAPI.Service
{
    public class CardCram
    {
        public int CardId  { get; set; }
        public int DeckId  { get; set; }
        public string Question  { get; set; }
        public string Answer { get; set; }

    }          
}
