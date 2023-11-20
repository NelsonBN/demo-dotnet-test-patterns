namespace Demo.Stub;

public interface IWeatherApiClient
{
    WeatherData GetWeatherData(string location);
}

public class WeatherApiClient : IWeatherApiClient
{
    public WeatherData GetWeatherData(string location)
    {
        return new WeatherData
        {
            AverageTemperature = Random.Shared.NextDouble() * 100
        };
    }
}