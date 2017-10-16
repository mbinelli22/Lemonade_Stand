using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variables
        public int cups;
        public int lemons;
        public int sugar;
        public int iceCubes;
        public int raspberrys;

        //constructor
        public Store()
        {

        }

        //member methods

        public void SellLemons(Player player)
        {
            Console.WriteLine("Enter how many lemons you would like to buy: \n\r '10' - '30' - '75'");
            int numberOfLemons = Console.ReadLine();
            switch (numberOfLemons)
            {
                case 10:
                    double priceOfLemons = 0.75;
                    Lemon lemon = new lemons();
                    player.invetory.Lemons.Add(lemon);

                    player.bank -= priceOfLemons;
                    break;
                case 30:
                    double priceOfLemons = 2.40;
                    Lemons lemon = new lemons();
                    player.invetory.Lemons.Add(lemon);

                    player.bank -= priceOfLemons;
                    break;
                case 75:
                    double priceOfLemons = 4.45;
                    Lemons lemon = new lemons();
                    player.invetory.Lemons.Add(lemon);

                    player.bank -= priceOfLemons;
                    break;
                default:
                    SellLemons(player);
                    break;
            }
        }

        public void SellCups(Player player)
        {
            Console.WriteLine("Enter how many cups you would like to buy: \n\r '25' - '50' - '100'");
            int numberOfCups = Console.ReadLine();
            switch (numberOfCups)
            {
                case 25:
                    double priceOfcups = 0.75;
                    cups cup = new cups();
                    player.invetory.Cups.Add(cup);

                    player.bank -= priceOfCups;
                    break;
                case 50:
                    double priceOfCups = 2.40;
                    cups cup = new cups();
                    player.invetory.Cups.Add(cup);

                    player.bank -= priceOfCups;
                    break;
                case 100:
                    double priceOfCups = 4.45;
                    cups cup = new cups();
                    player.invetory.Cups.Add(cup);

                    player.bank -= priceOfCups;
                    break;
                default:
                    SellCups(player);
                    break;
            }
        }


        private void buySugar()
        {

        }

        private void buyRaspberrys()
        {

        }

        private void buyIceCubes()
        {

        }


    }
}
