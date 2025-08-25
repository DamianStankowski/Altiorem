namespace Altiorem.Domain.Abstractions;

public interface IRepository<TAggregate, TIdentifier> : IReadRepository<TAggregate, TIdentifier>
    where TAggregate : class, IAggregateRoot
{
    Task AddAsync(TAggregate entity, CancellationToken ct = default);
    Task UpdateAsync(TAggregate entity, CancellationToken ct = default);
    Task DeleteAsync(TAggregate entity, CancellationToken ct = default);
}