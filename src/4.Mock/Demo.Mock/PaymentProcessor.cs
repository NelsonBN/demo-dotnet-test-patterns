namespace Demo.Mock;

public class PaymentProcessor
{
    private readonly IPaymentGateway _paymentGateway;

    public PaymentProcessor(IPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }

    public bool ProcessPayment(PaymentDetails paymentDetails)
    {
        return _paymentGateway.Charge(paymentDetails.Amount);
    }
}
