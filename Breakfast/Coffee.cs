using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Breakfast
{
    public class Coffee
    {
        public string temperature;
        public string Temperature { get { return TemperatureOfCoffe(temperature); } set { temperature = value; } }
        public string TemperatureOfCoffe(String value)
        {
            if (value == null)
            {
                temperature = "Hot";
            }
            else if (value.Equals("Hot"))
            {
                temperature = "Quite hot";
            }
            else if (value.Equals("Quite hot"))
            {
                temperature = "Not so hot";
            }
            else if (value.Equals("Not so hot"))
            {
                temperature = "Cold";
            }
            return temperature;
        }
    }
}
