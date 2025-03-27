using Data.Entities.Customers;
using Data.Repositories.Interfaces;

namespace Data.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public Task<int> Create(Customer customer, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
        
    }
    public Task<Customer> GetByCustomerId(int customerId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<List<Customer>> GetCustomers(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int customerId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task Update(Customer customer, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}