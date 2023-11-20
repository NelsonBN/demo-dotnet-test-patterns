using Demo.Dummy;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder().Build();

var processor = new OrderProcessor(configuration);
processor.ProcessOrder(new Order(5.12));
