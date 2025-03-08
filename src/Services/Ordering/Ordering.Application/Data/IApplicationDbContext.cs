namespace Ordering.Application.Data;
public interface IApplicationDbContext
{
    DbSet<Customer> Customers { get; }
    DbSet<Product> Products { get; }
    DbSet<Order> Orders { get; }
    DbSet<OrderItem> OrderItems { get; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}