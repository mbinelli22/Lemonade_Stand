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
        public string cups;
        public string lemons;
        public string sugar;
        public string iceCubes;
        public string raspberrys;

        //constructor
        public Store()
        {

        }

        //member methods

        public void SellHops(Player player)
        {
            int numberOfHops = 10;
            double priceOfHops = 2.50;

            Hops hop = new Hops();
            player.inventory.hops.Add(hop);

            player.money -= priceOfHops;
        }


        public void SellLemons()
        {
            Console.WriteLine("Enter how many lemons you would like to buy: \n\r '10' - '30' - '75'");
            int numberOfLemons = Console.ReadLine();

        }

        public void buyCups()
        {
            Console.WriteLine("You currently have, " + invetoryCups + "cups. Enter how many you would like to buy. \n\r 25 - 50 - 100");
        }

        private void buyLemons()
        {

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
