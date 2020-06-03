using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE06
{
    class Card
    {
        string _name;
        string _cardDescription;
        decimal _cardValue;

        public Card (string Name, string CardDescription, decimal CardValue)
        {
            _cardDescription = CardDescription;
            _name = Name;
            _cardValue = CardValue;
        }
        public override string ToString()
        {
            return "\n Name: " + _name + "\n Card Description: " + _cardDescription + "\n Card Value: " + _cardValue;
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string CardDescription
        {
            get
            {
                return _cardDescription;
            }

            set
            {
                _cardDescription = value;
            }
        }

        public decimal CardValue
        {
            get
            {
                return _cardValue;
            }

            set
            {
                _cardValue = value;
            }
        }
    }
}
