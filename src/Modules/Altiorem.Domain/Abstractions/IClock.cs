namespace Altiorem.Domain.Abstractions;

public interface IClock
{
DateTimeOffset UtcNow { get; }
}