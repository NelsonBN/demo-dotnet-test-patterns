using Demo.Stub;

var apiClient = new WeatherApiClient();

var service = new WeatherService(apiClient);
service.GetAverageTemperature("Lisbon");
