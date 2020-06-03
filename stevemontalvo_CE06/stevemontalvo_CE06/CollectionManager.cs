using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE06
{
    class CollectionManager
    {
        //list for available cards
        List <Card> Cards;
        //Hold Multiple Collections of cards
        Dictionary<string, List<Card>> Collection;

        public void Remove (string Card)
        {    
                Cards.Add(Card);     

        }
        public void AddDictionary(string Card, string Description)
        {
            Collection.Add(Card, Description);
        }
    }
}
