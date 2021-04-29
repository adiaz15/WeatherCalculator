using System;

namespace BasicWeatherCalculator
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Weather Calculator");

            Console.WriteLine("Enter your name");

            string name = Console.ReadLine();

            Console.WriteLine("Enter the Temperature in Fahrenheit");

            double temperature;

            string firstentry = Console.ReadLine();

            double.TryParse(firstentry, out temperature);

            Console.WriteLine("Enter the Relative Humidity");

            double relativeHumidity;

            string secondEntry = Console.ReadLine();

            double.TryParse(secondEntry, out relativeHumidity);
            
            double dewPoint = temperature - 9.00 / 25.00 * (100.00 - relativeHumidity);

            Console.WriteLine("the dew point is " + dewPoint);

            Console.WriteLine("Enter the wind speed");

            double windSpeed;
            
            string thirdEntry = Console.ReadLine();

            double.TryParse(thirdEntry, out windSpeed);

            double exponent = 0.16;

            double windchill = 35.74 + 0.6215 * temperature - 35.75 * Math.Pow(windSpeed, exponent) + 0.4275 * temperature * Math.Pow(windSpeed, exponent);

            Console.WriteLine("the windchill is " + windchill);
        }
    }
}