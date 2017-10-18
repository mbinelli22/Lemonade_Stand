using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        public Weather weather;
        List<int> customers = new List<int>();
        private int day;


        //constructor
        public Day()
        {
            
        }

        //member methods
        
        //keep track of what day it is

        public void dayOne(Weather weather)
        {
            new forecast = weather.forecast();
            Console.WriteLine("The forecast for day one is: " + forecast);
            new temperature = weather.temperature();
            Console.WriteLine("The temperature for day one is: " + temperature);
        }
        
        public void dayTwo()
        {
            new forecast = weather.forecast();
            Console.WriteLine("The forecast for day two is: " + forecast);
            new temperature = weather.temperature();
            Console.WriteLine("The weather for day two is: " + temperature);
        }

        public void dayThree()
        {
            new forecast = weather.forecast();
            Console.WriteLine("The forecast for day three is: " + forecast);
            new temperature = weather.temperature();
            Console.WriteLine("The weather for day three is: " + temperature);
        }
        
        public void dayFour()
        {
            new forecast = weather.forecast();
            Console.WriteLine("The forecast for day four is: " + forecast);
            new temperature = weather.temperature();
            Console.WriteLine("The weather for day four is: " + temperature);
        }

        public void dayFive()
        {
            new forecast = weather.forecast();
            Console.WriteLine("The forecast for day five is: " + forecast);
            new temperature = weather.temperature();
            Console.WriteLine("The weather for day five is: " + temperature);
        }

        public void daySix()
        {
            new forecast = weather.forecast();
            Console.WriteLine("The forecast for day six is: " + forecast);
            new temperature = weather.temperature();
            Console.WriteLine("The weather for day six is: " + temperature);
        }
        
        public void daySeven()
        {
            new forecast = weather.forecast();
            Console.WriteLine("The forecast for day seven is: " + forecast);
            new temperature = weather.temperature();
            Console.WriteLine("The weather for day seven is: " + temperature);
        }
        
        //weather


        //list of customers



    }
}
