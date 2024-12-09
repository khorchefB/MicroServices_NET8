using Ordering.Domain.Abstractions;

namespace Ordering.Domain.Abstraction;

public interface IAggregate<T> : IAggregate, IEntity<T>
{

}

public interface IAggregate : IEntity
{   
    IReadOnlyList<IDomainEvent> DomainEvent { get; }
    IDomainEvent[] ClearDomainEvents();
}
