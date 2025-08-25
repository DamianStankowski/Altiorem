namespace Altiorem.Domain.Abstractions;

public interface IHasDomainEvents
{
    IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
    void Raise(IDomainEvent @event);
    void ClearDomainEvents();
}
