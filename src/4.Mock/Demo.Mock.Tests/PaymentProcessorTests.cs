using NSubstitute;

namespace Demo.Mock.Tests;

public class PaymentProcessorTests
{
    [Fact]
    public void ProcessPayment_WhenCalled_ShouldInvokePaymentGateway()
    {
        // Arrange
        var gateway = Substitute.For<IPaymentGateway>();
        gateway
            .Charge(Arg.Any<decimal>())
            .Returns(true);

        var processor = new PaymentProcessor(gateway);

        var payment = new PaymentDetails { Amount = 100m };


        // Act
        var act = processor.ProcessPayment(payment);


        // Assert
        gateway.Received(1)
               .Charge(payment.Amount);

        Assert.True(act);
    }
}