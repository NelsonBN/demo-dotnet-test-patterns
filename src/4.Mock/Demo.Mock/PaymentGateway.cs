namespace Demo.Mock;

public interface IPaymentGateway
{
    bool Charge(decimal amount);
}

public class PaymentGateway : IPaymentGateway
{
    public bool Charge(decimal amount)
    {
        return true;
    }
}
