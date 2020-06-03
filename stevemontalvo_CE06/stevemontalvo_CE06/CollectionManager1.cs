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
        List <string> Cards;
        //Hold Multiple Collections of cards
        Dictionary<string, string> Collection;

        public Dictionary<string, string> Collection1
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

        public List<string> Cards1
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

        public void RemoveList (string Card)
        {
            Cards = new List<string>();
            Cards.Remove(Card);     

        }
        public void AddList (string Card)
        {
            Cards = new List <string>();
            Cards.Add(Card);
        }

        public void AddDictionary(string Card, string Description)
        {
            Collection.Add(Card, Description);
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

      }
 }

