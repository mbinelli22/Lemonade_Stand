using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        public Game game;
        public Day day;
        public Store store;

        static void Main(string[] args)
        {
            Game game = new Game();
            game.displayRules();
            game.nameStand();
            
        }
    }
}
