using Demo.Fake;

var repository = new CustomerRepository();

var service = new CustomerService(repository);
service.GetById(421);
