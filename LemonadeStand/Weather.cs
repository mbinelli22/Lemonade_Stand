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
        public string SunnyAndHumid;

        //constructor
        public Weather()
        {

        }

        //member methods
        List<string> forecast = new List<string>();
        forecast.Add("Rainy");
        forecast.Add("Overcast");
        forecast.Add("Sunny");
        forecast.Add("Sunny and Humid");



    }
}
