using Demo.Mock;

var gateway = new PaymentGateway();

var service = new PaymentProcessor(gateway);
service.ProcessPayment(new() { Amount = 12 });
