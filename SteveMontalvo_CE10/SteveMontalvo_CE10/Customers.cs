using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE10
{
    class Customers
    {
        List<Customers> CustomerItems = new List<Customers>();

        internal List<Customers> CustomerItems1
        {
            get
            {
                return CustomerItems;
            }

            set
            {
                CustomerItems = value;
            }
        }

    }
}
