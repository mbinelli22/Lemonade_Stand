using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // member variables
        public Player player;
        public Day day;
        public Store store;



        // constructor
        public Game()
        {

        }


        //member methods

        // We are currently in the Game class
        // The method "InfluenceChanceBasedOnPrice() is located in the Customer class
        //for (int i = 0; i<day.customers.Count; 
        // {
        //day.customers[i].InfluenceChanceBasedOnPrice(player.recipe.price);
        // }


        public void displayRules()
        {
            Console.WriteLine("Your goal is to make as much money possible in 7 days.");
            Console.WriteLine("Buy cups, lemons, sugar, raspberrys and ice cubes and alter your recipe and your price based on the weather.");
            Console.WriteLine("May the odds be ever in your favor.");
            Console.ReadLine();
        }

        public void nameStand()
        {
            Console.WriteLine("Enter your name: ");
            string playerOne = Console.ReadLine();
            Console.WriteLine("Welcome To " + playerOne + "'s Lemonade Stand!");
        }

        private void displayWeatherWeek()
        {

        }

        public void displayWeatherCurrentDay(Weather weather)
        {
            Console.WriteLine("Todays weather is: " +  day.weather.temperature + "degrees fahrenheit.");
        }

       private void displayCurrentInvetory()
        {



            Console.WriteLine("Would you like to restock on any items?");
            string restockAnswer = Console.ReadLine(); 
            if (restockAnswer == "yes")
            {
                buyItems();
            }
            else
            {
                //go to play game 
            }
        }

        private void buyItems()
        {
            Console.WriteLine("Enter what you want to purchase more of: \n\r CUPS - LEMONS - SUGAR - RASPBERRYS - ICE CUBES");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "cups":
                    store.SellCups(player);
                    break;
                case "lemon":
                    store.SellLemons(player);
                    break;
                case "sugar":
                    store.sellSugar(player);
                    break;
                case "raspberry":
                    store.sellRaspberrys(player);
                    break;
                case "ice cubes":
                    store.sellIceCubes(player);
                    break;
                default:
                    buyItems();
                    break;
           }
        }








        









    }
}
