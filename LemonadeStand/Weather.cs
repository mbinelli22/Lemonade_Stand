using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //memeber variables
        public string Rainy;
        public string Sunny;
        public string Overcast;

        //constructor
        public Weather()
        {
            List<string> forecast = new List<string>();
            forecast.Add("Rainy");
            forecast.Add("Overcast");
            forecast.Add("Sunny");
        }

        //member methods
        public void forecast()
        {
            List<string> forecast = new List<string>();
            var rnd = new Random();
            var result = forecast.OrderBy(item => rnd.Next());
        }

        public void temperature()
        {
            Random rnd = new Random();
            int temperature = rnd.Next(50, 100);
        }



    }
}
