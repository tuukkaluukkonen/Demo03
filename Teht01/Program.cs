using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new HeaterApplication.Heater();
            heater.IsOn = true;
            heater.Temperature = 87;
            heater.Humidity = 95.4;
            heater.ThrowWater();
            Console.WriteLine("Temperature is " + heater.Temperature);
            Console.WriteLine("Humidity is " + heater.Humidity);

        }
    }
}
