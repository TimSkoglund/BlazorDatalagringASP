using Data.Entities.Customers;

namespace Data.Repositories.Interfaces;

public interface ICustomerRepository
{
    Task<int> Create(Customer customer, CancellationToken cancellationToken);
    Task<Customer> GetByCustomerId(int customerId, CancellationToken cancellationToken);
    Task<List<Customer>> GetCustomers(CancellationToken cancellationToken);
    Task Update(Customer customer, CancellationToken cancellationToken);
    Task Delete(int customerId, CancellationToken cancellationToken);
}