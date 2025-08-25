namespace Altiorem.Domain.Abstractions;

public interface IPagedList<out TItem>
{
    int Page { get; }
    int Size { get; }
    int TotalCount { get; }
    IEnumerable<TItem> Items { get; }
}