using System.Linq.Expressions;

namespace Altiorem.Domain.Abstractions;

public interface ISpecification<T>
{
    Expression<Func<T, bool>>? Criteria { get; }
    IReadOnlyList<IOrderBy<T>> OrderBy { get; }
}