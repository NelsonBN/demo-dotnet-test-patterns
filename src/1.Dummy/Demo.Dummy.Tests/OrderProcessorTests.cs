using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace Demo.Dummy.Tests;

public class OrderProcessorTests
{
    [Fact]
    public void ProcessOrder_WithValidOrder_ShouldProcessCorrectly()
    {
        // Arrange
        var dummyConfig = new DummyConfiguration();
        var processor = new OrderProcessor(dummyConfig);

        var order = new Order(1.54);


        // Act
        var act = processor.ProcessOrder(order);


        // Assert
        Assert.True(act);
    }

    public class DummyConfiguration : IConfiguration
    {
        public string? this[string key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            throw new NotImplementedException();
        }

        public IChangeToken GetReloadToken()
        {
            throw new NotImplementedException();
        }

        public IConfigurationSection GetSection(string key)
        {
            throw new NotImplementedException();
        }
    }
}