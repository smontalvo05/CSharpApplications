using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE10
{
    class Inventory_Items
    {
        List <Inventory_Items> Inventory = new List <Inventory_Items>();

        internal List<Inventory_Items> Inventory1
        {
            get
            {
                return Inventory;
            }

            set
            {
                Inventory = value;
            }
        }
    }
}
