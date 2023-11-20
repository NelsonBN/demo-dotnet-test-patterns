namespace Demo.Fake;

public class CustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Customer? GetById(int id)
    {
        return _customerRepository.FindById(id);
    }
}
