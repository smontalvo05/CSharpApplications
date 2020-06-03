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
        List <Card> Cards = new List<Card>();
        //Hold Multiple Collections of cards
        Dictionary<string, List<Card>> Collection = new Dictionary<string, List<Card>>();

        internal Dictionary<string, List<Card>> Collection1
        {
            get
            {
                return Collection;
            }

            set
            {
                Collection = value;
            }
        }

        internal List<Card> Cards1
        {
            get
            {
                return Cards;
            }

            set
            {
                Cards = value;
            }
        }

        public void RemoveCard <t> (List <t> Cards1)
        {
           // Validate that the user uses a number for the index
            int i = UserValidation.IndexNumberCheck();
            //check if the user entered a number within the index to remove
            if (i >= 0 && i < Cards1.Count)
            {
                Cards1.RemoveAt(i);
            }
            else
            {
                Console.WriteLine("The number you have chosen " + i + " is not within the numbers that are in the list. You must choose a number that is within index numbers that are shown." );

            }    

        }
        
        public void AddCardToList (Card Card)
        {

            Cards1.Add(Card);
          
        }

        public void AddToCollection (string key, List<Card> Cards)
        {

           Collection1.Add(key, Cards);
           
        }

        public void DisplayCollection<tk, tv>(Dictionary<tk,tv>Collection)
        {
            if (Collection.Count > 0)
            {
                Console.WriteLine("\n Card Collection Keys and Values: \n-----------------------------");
                int i = 0;
                foreach (tk key in Collection.Keys)
                {
                    Console.WriteLine(i + ".) Key:\"" + key + "\" Value: " + Collection[key]);
                    ++i;
                }
            }
            else
            {
                Console.WriteLine("No values to print!");
            }
            Console.Write("\n");
       }
        public void DisplayList<t>(List<t> _list)
        {
            if (_list.Count > 0)
            {
                Console.WriteLine("\n Card List Keys and Values: \n-----------------------------");
                int i = 0;
                foreach (t key in _list)
                {
                    Console.WriteLine("Index ["+i+"] Value: "+ key);
                    ++i;
                }
            }
            else
            {
                Console.WriteLine("No values to print!");
            }
            Console.Write("\n");
        }
    }
   
}

