namespace Monads.Core.MaybeMonad;

public static class EnumerableExtensions
{
    public static IMaybe<T> MaybeElementAt<T>(this IEnumerable<T> xs, int i)
    {
        try { return Maybe<T>.Factory(xs.ElementAt(i)); }
        catch { return new None<T>(); }
    }
    
    public static IMaybe<T> MaybeFirst<T>(this IEnumerable<T> xs)
    {
        var enumerable = xs.ToList();
        return enumerable.Any() ? Maybe<T>.Factory(enumerable.First()) : new None<T>();
    }

    public static IMaybe<T> MaybeLast<T>(this IEnumerable<T> xs)
    {
        var enumerable = xs.ToList();
        return enumerable.Any() ? Maybe<T>.Factory(enumerable.Last()) : new None<T>();
    }
}