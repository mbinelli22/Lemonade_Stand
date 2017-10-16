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
            Console.WriteLine("Your goal is to make as much money possible in 7 days. \n\rBuy cups, lemons, sugar, raspberrys and ice cubes and alter your recipe and your price based on the weather. \n\rMay the odds be ever in your favor");
            Console.ReadLine();
        }

        private void displayWeatherWeek()
        {

        }

        public void displayWeatherCurrentDay()
        {

        }

        private void displayMoney()
        {

        }

        private void displayCurrentDay()
        {

        }

        private void displayCurrentInvetory()
        {



            Console.WriteLine("Would you like to restock on any items?");
            bool restockAnswer = Console.ReadLine(); 
            if (!restockAnswer)
            {
                // continue to playing game
            }
            else
            {
                buyItems();
            }
        }

        private void buyItems()
        {
            Console.WriteLine("Enter what you want to purchase more of: \n\r CUPS - LEMONS - SUGAR - RASPBERRYS - ICE CUBES");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "cups":
                    
                    break;
                case "lemon":
                    
                    break;
                case "sugar":
                    
                    break;
                case "raspberry":
                    
                    break;
                case "ice cubes":
                    
                    break;
                default:
                    buyItems();
                    break;
           }
        }








        









    }
}
