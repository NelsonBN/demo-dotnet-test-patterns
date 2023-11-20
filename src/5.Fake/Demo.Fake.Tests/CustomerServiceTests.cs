namespace Demo.Fake.Tests;

public class CustomerServiceTests
{
    [Fact]
    public void GetCustomerById_WithExistingId_ReturnsCustomer()
    {
        // Arrange
        var repository = new FakeCustomerRepository();
        var service = new CustomerService(repository);


        // Act
        var act = service.GetById(2);


        // Assert
        Assert.NotNull(act);
        Assert.Equal(2, act.Id);
        Assert.Equal("Jane Smith", act.Name);
    }

    public class FakeCustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = [];

        public FakeCustomerRepository()
        {
            _customers.Add(new() { Id = 1, Name = "John Doe" });
            _customers.Add(new() { Id = 2, Name = "Jane Smith" });
        }

        public Customer? FindById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }
    }
}