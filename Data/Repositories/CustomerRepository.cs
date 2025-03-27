using Data.Context;
using Data.Entities.Customers;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;
    
public class CustomerRepository : ICustomerRepository
{
    private readonly BlazorDatalagringContext _databaseContext;

    public CustomerRepository(BlazorDatalagringContext context)
    {
        _databaseContext = context;
    }
    public async Task<int> Create(Customer customer, CancellationToken cancellationToken)
    {
        await _databaseContext.AddAsync(customer);
        return await _databaseContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<Customer> GetByCustomerId(int customerId, CancellationToken cancellationToken)
    {
        // Den hämtade kunden | databasen.    tabellen. vad man vill göra
        var customer = await _databaseContext.Customer.FindAsync(customerId, cancellationToken);
        return customer;
    }

    public async Task<List<Customer>> GetCustomers(CancellationToken cancellationToken)
    {
        var customers = await _databaseContext.Customer.ToListAsync(cancellationToken);
        return customers ?? new();
    }

    public async Task Delete(int customerId, CancellationToken cancellationToken)
    {
        var customer = await GetByCustomerId(customerId, cancellationToken);

        _databaseContext.Customer.Remove(customer);
        await _databaseContext.SaveChangesAsync(cancellationToken);
    }

    public async Task Update(Customer customer, CancellationToken cancellationToken)
    {
        _databaseContext.Customer.Update(customer);
        await _databaseContext.SaveChangesAsync(cancellationToken);
    }
}