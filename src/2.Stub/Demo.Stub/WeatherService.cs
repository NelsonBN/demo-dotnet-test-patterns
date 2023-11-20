namespace Demo.Stub;

public class WeatherService
{
    private readonly IWeatherApiClient _weatherApiClient;

    public WeatherService(IWeatherApiClient weatherApiClient)
    {
        _weatherApiClient = weatherApiClient;
    }

    public double GetAverageTemperature(string location)
    {
        var weatherData = _weatherApiClient.GetWeatherData(location);
        return weatherData.AverageTemperature;
    }
}
