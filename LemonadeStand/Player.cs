using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //bank
        // invetory -> in invetory have a list of lemons etc
        //recipe
    
        private string playerOne;

        public Player()
        {

        }

        private void nameStand()
        {
            Console.WriteLine("Enter your name: ");
            string playerOne = Console.ReadLine();
            Console.WriteLine("Welcome To " + playerOne + "'s Lemonade Stand!");
        }
    }
}
