namespace Monads.Core.MaybeMonad;

public class Some<T> : IMaybe<T>
{
    private readonly T _value;
        
    internal Some(T value) {
        _value = value;
    }

    public TNext Match<TNext>(Func<T, TNext> some, Func<TNext> none)
        => some(_value);

    public IMaybe<TNext> Map<TNext>(Func<T, TNext> func)
        => Maybe<TNext>.Factory(func(_value));
        
    public IMaybe<TU> Bind<TU>(Func<T, IMaybe<TU>> func)
        => func(_value);
      
}