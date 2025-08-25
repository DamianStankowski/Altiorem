namespace Altiorem.Domain.Abstractions;

public interface IDomainEvent
{
    DateTimeOffset OccurredOn { get; }
    string EventName { get; }
}