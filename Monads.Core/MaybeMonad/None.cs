namespace Monads.Core.MaybeMonad;

public class None<T> : IMaybe<T>
{
    public TNext Match<TNext>(Func<T, TNext> some, Func<TNext> none)
        => none();

    public IMaybe<TNext> Map<TNext>(Func<T, TNext> func)
        => new None<TNext>();
            
    public IMaybe<TU> Bind<TU>(Func<T, IMaybe<TU>> func)
        => new None<TU>();
}