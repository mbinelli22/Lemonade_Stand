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
                    lemons lemon =
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


        public void sellSugar(Player player)
        {
            Console.WriteLine("Enter how many cups of sugar you would like to buy: \n\r '8' - '20' - '50'");
            int numberOfSugarCups = Console.ReadLine();
            switch (numberOfSugarCups)
            {
                case 8:
                    double priceOfSugar = 0.75;
                    sugar sugar = new sugar();
                    player.invetory.Sugar.Add(sugar);

                    player.bank -= priceOfSugar;
                    break;
                case 20:
                    double priceOfSugar = 1.60;
                    sugar sugar = new sugar();
                    player.invetory.Sugar.Add(sugar);

                    player.bank -= priceOfSugar;
                    break;
                case 50:
                    double priceOfSugar = 3.30;
                    sugar sugar = new sugar();
                    player.invetory.Sugar.Add(sugar);

                    player.bank -= priceOfSugar;
                    break;
                default:
                    sellSugar(player);
                    break;
            }
        }

        public void sellRaspberrys(Player player)
        {
            Console.WriteLine("Enter how many lemons you would like to buy: \n\r '10' - '30' - '75'");
            int numberOfRaspberrys = Console.ReadLine();
            switch (numberOfRaspberrys)
            {
                case 15:
                    double priceOfRaspberrys= 0.90;
                    Raspberrys raspberrys = new Raspberrys();
                    player.invetory.Raspberrys.Add(raspberrys);

                    player.bank -= priceOfRaspberrys;
                    break;
                case 30:
                    double priceOfRaspberrys = 2.90;
                    Raspberrys raspberrys = new Raspberrys();
                    player.invetory.Raspberrys.Add(raspberrys);

                    player.bank -= priceOfRaspberrys;
                    break;
                case 75:
                    double priceOfLemons = 5.00;
                    Lemons lemon = new lemons();
                    player.invetory.Lemons.Add(lemon);

                    player.bank -= priceOfLemons;
                    break;
                default:
                    SellLemons(player);
                    break;
            }
        }

        public void sellIceCubes(Player player)
        {
            Console.WriteLine("Enter how many ice cubes you would like to buy: \n\r '10' - '30' - '75'");
            int numberOfIceCubes = Console.ReadLine();
            switch (numberOfIceCubes)
            {
                case 100:
                    double priceOfIceCubes = 0.75;
                    iceCubes iceCubes = new iceCubes();
                    player.invetory.IceCubes.Add(iceCubes);

                    player.bank -= priceOfIceCubes;
                    break;
                case 200:
                    double priceOfIceCubes = 2.15;
                    iceCubes iceCubes = new iceCubes();
                    player.invetory.IceCubes.Add(iceCubes);

                    player.bank -= priceOfIceCubes;
                    break;
                case 500:
                    double priceOfIceCubes = 4.00;
                    iceCubes iceCubes = new iceCubes();
                    player.invetory.IceCubes.Add(iceCubes);

                    player.bank -= priceOfIceCubes;
                    break;
                default:
                    sellIceCubes(player);
                    break;
            }
        }


    }
}
