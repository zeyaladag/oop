namespace Azon.WeatherLib
{
    public class Reporter
    {
        private List<City> cityList = [];

        public void AddCity(City city)
        {
            cityList.Add(city);
        }
        public City GetCity(string cityName)
        {
            // program crashes if exception objects does not catch with try/catch blocks 
            throw new NotImplementedException();
        }
        public List<City> GetCityList()
        {
            return cityList;
        }
        public Temperature GetTemperature(string cityName)
        {
            /* when there is a new method but it's content hasn't been declared yet, we can use NotImplementeException to
             * notify other programmers or object users. we can throw an Exception object to the runtime. below line is an instance
             * of an exception. we control them with try/catch mechanisms. */
            throw new NotImplementedException();
        }
        public string GetSummary()
        {
            throw new NotImplementedException();
        }
    }
}