using Microsoft.Extensions.Configuration;

namespace Demo.Dummy;

public class OrderProcessor
{
    private readonly IConfiguration _configuration;

    public OrderProcessor(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public bool ProcessOrder(Order order)
    {
        if (order.Value > 0)
        {
            return true;
        }

        return false;
    }
}