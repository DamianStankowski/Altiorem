namespace Altiorem.Domain.Abstractions;

public interface IReadRepository<TAggregate, TIdentifier>
    where TAggregate : class, IAggregateRoot
{
    Task<TAggregate> GetAsync(ISpecification<TAggregate> spec, CancellationToken ct = default);
    Task<IReadOnlyCollection<TAggregate>> ListAsync(ISpecification<TAggregate> spec, CancellationToken ct = default);
    Task<bool> ExistsAsync(ISpecification<TAggregate> spec, CancellationToken ct = default);
    Task<IPagedList<TAggregate>> PagedListAsync(ISpecification<TAggregate> spec, CancellationToken ct = default);
}