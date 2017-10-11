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



        // constructor
        public Game()
        {

        }


        //member methods

        public void displayRules()
        {
            Console.WriteLine("//WRITE OUT RULES!!!!!");
        }

        private void displayWeatherWeek()
        {

        }

        displayWeatherCurrentDay()
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
            Console.WriteLine("Enter what you want to purchase more of: \n CUPS - LEMONS - SUGAR - RASPBERRYS - ICE CUBES");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "cups":
                    buyCups();
                    break;
                case "lemon":
                    buyLemons();
                    break;
                case "sugar":
                    buySugar();
                    break;
                case "raspberry":
                    buyRaspberrys();
                    break;
                case "ice cubes":
                    buyIceCubes();
                    break;
           }
        }

        private void buyCups()
        {
            Console.WriteLine("You currently have, " + invetoryCups + "cups. Enter how many you would like to buy. \n 25 - 50 - 100");
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
