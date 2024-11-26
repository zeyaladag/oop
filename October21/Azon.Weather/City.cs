namespace Azon.WeatherLib
{
    public class City
    {
        public string Name { get; private set; }
        public Temperature Temperature { get; private set; }
        public City(string name, Temperature temperature)
        {
            Name = name;
            Temperature = temperature;
        }
    }
}
