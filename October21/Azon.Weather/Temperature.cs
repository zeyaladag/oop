namespace Azon.Weather
{/* class libraries aren't executable assemblies like console apps.
  * they include functions and types other projects can reference to.
  * 
  * temperature class is for converting fahreheit and celcius vice versa.
  */
    public struct Temperature
    {
        public double Value { get; set; }
        public TemperatureType Type { get; set; }
        public Temperature(double value, TemperatureType type)
        {
            Value = value;
            Type = type;
        }
        public double Convert2Celcius()
        {
            // early return : if there is a possibility for less operations with quicker execution
            if (Type == TemperatureType.Celcius)
            {
                Type = TemperatureType.Fahrenheit;
                return (Value -32) * 5.0 / 9.0;
            }
            return Value;
        }
        public double Convert2Fahrenheit()
        {
            if (Type == TemperatureType.Celcius)
            {
                Type = TemperatureType.Fahrenheit;
                return (Value * 9.0 / 5.0) + 32;
            }
            return Value;
        }
    }
    public enum TemperatureType
    {
        Celcius,
        Fahrenheit
    }
}
