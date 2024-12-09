
namespace Ordering.Domain.Abstraction;

public abstract class Aggregate<TId> : Entity<TId>, IAggregate<TId>
{
    private readonly List<IDomainEvent> _domainEvent = new();
    public IReadOnlyList<IDomainEvent> DomainEvent => _domainEvent.AsReadOnly();
    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvent.Add(domainEvent);
    }
    public IDomainEvent[] ClearDomainEvents()
    {
        IDomainEvent[] dequeudEvents = _domainEvent.ToArray();
        _domainEvent.Clear();
        return dequeudEvents;
    }
}
