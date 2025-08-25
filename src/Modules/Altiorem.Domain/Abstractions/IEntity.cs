namespace Altiorem.Domain.Abstractions;

public interface IEntity<out TIdentifier>
{
    TIdentifier Id { get; }
}