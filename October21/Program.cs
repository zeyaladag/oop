using October21.UI.View;
using Azon.Weather;

namespace October21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userName = Console.ReadLine(); //used for user input from terminal
            TerminalUI.SplashScreen(userName);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            var currentWeatherValue = new Temperature(21, TemperatureType.Celcius);
            Console.WriteLine("Temperature is {0}",currentWeatherValue);
        }
    }
}