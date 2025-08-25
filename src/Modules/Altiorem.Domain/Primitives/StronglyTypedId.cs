namespace Altiorem.Domain.Primitives;

public abstract record StronglyTypedId<TValue>(TValue Value)
{
    public override string ToString()
    {
        return Value?.ToString() ?? string.Empty;
    }
}