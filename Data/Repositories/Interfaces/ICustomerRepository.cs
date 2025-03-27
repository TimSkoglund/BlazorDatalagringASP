using Data.Entities.Customers;

namespace Data.Repositories.Interfaces;

public interface ICustomerRepository
{
    Task<int> Create(Customer customer, CancellationToken cancellationToken);
    Task<Customer> GetByCustomerId(int customerId, CancellationToken cancellationToken);
    Task<Customer> GetCustomer(CancellationToken cancellationToken);
}