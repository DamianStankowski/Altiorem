using Altiorem.Domain.Abstractions;

namespace Altiorem.Domain.Primitives;

public abstract class AggregateRoot<TIdentifier>(TIdentifier id) 
    : Entity<TIdentifier>(id), IAggregateRoot, IHasDomainEvents
{
    public IReadOnlyCollection<IDomainEvent> DomainEvents { get; protected init; } = [];

    public void ClearDomainEvents()
    {
        throw new NotImplementedException();
    }

    public void Raise(IDomainEvent @event)
    {
        throw new NotImplementedException();
    }
}