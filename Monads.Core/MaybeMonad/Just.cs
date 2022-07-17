namespace Monads.Core.MaybeMonad;

public class Just<T> : IMaybe<T>
{
    private readonly T _value;
        
    internal Just(T value) {
        _value = value;
    }

    public TNext Match<TNext>(Func<T, TNext> just, Func<TNext> nothing)
        => just(_value);

    public IMaybe<TNext> Bind<TNext>(Func<T, IMaybe<TNext>> func)
        => func(_value);

    public bool Equals<TNext>(IMaybe<TNext> obj)
    {
        return obj.Match(
            just => just.Equals(_value), 
            () => false);
    }
}