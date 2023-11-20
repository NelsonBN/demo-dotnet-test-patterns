namespace Demo.Stub.Tests;

public class WeatherServiceTests
{
    [Fact]
    public void GetAverageTemperature_WithValidLocation_ReturnsFixedTemperature()
    {
        // Arrange
        var apiClient = Substitute.For<IWeatherApiClient>();
        apiClient
            .GetWeatherData(Arg.Any<string>())
            .Returns(new WeatherData { AverageTemperature = 26.5 });

        var service = new WeatherService(apiClient);


        // Act
        var act = service.GetAverageTemperature("Lisbon");


        // Assert
        Assert.Equal(26.5, act);
    }
}