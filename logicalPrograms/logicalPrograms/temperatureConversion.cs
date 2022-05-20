using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalPrograms
{
    internal class temperatureConversion
    { 
        public void convertTemperature()
        {
            double celsius = 0, fahrenheit = 0;
            Console.WriteLine("Enter 1 to Celsius to Fahrenheit");
            Console.WriteLine("Enter 2 to Fahrenheit to Celsius");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter Celsius value");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    fahrenheit = (celsius * 1.8) + 32;
                    Console.WriteLine(celsius + " Celsius to Fahrenheit " + Math.Round(fahrenheit,2) + "°F");
                    break;
                case 2:
                    Console.WriteLine("Enter Fahrenheit value");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fahrenheit - 32) * .5556;
                    Console.WriteLine(fahrenheit + " Fahrenheit to Celsius " + Math.Round(celsius,2) + "°C");
                    break;
            }
        }
    }
}
