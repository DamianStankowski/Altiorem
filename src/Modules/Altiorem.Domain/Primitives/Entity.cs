using Altiorem.Domain.Abstractions;

namespace Altiorem.Domain.Primitives;

public abstract class Entity<TIdentifier>(TIdentifier id) : IEntity<TIdentifier>
{
    public TIdentifier Id { get; protected init; } = id;

    public override bool Equals(object? obj)
    {
        return obj is Entity<TIdentifier> other && EqualityComparer<TIdentifier>.Default.Equals(Id, other.Id);
    }

    public override int GetHashCode()
    {
        return EqualityComparer<TIdentifier>.Default.GetHashCode(Id!); ;
    }
}