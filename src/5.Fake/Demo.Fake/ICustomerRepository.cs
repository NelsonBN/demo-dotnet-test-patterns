namespace Demo.Fake;

public interface ICustomerRepository
{
    Customer? FindById(int id);
}


public class CustomerRepository : ICustomerRepository
{
    public Customer? FindById(int id)
    {
        return new Customer { Id = id, Name = "John Doe" };
    }
}
