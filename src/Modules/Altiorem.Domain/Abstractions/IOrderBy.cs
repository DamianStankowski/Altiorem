using System.Linq.Expressions;

namespace Altiorem.Domain.Abstractions;

public interface IOrderBy<T>
{
    Expression<Func<T, object>> KeySelector { get; }
    bool Descending { get; }
}