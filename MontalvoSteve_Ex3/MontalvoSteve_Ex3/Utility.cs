using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex3
{
    class Utility
    {
        //Method to pause the screen and look for a user response with any key
        public static void PauseBeforeContinuing()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }
    }
}
