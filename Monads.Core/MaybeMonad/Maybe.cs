namespace Monads.Core.MaybeMonad;

public static class Maybe<T>
{
    public static IMaybe<T> Factory(T value) {
        return value == null ? new Nothing<T>() : new Just<T>(value);
    }
}