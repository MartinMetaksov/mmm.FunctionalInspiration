namespace Monads.Core.MaybeMonad;

public class Nothing<T> : IMaybe<T>
{
    public TNext Match<TNext>(Func<T, TNext> just, Func<TNext> nothing)
        => nothing();

    public IMaybe<TNext> Map<TNext>(Func<T, TNext> func)
        => new Nothing<TNext>();
            
    public IMaybe<TNext> Bind<TNext>(Func<T, IMaybe<TNext>> func)
        => new Nothing<TNext>();
    
    public bool Equals<TNext>(IMaybe<TNext> obj)
    {
        return obj.Match(
            _ => false, 
            () => true);
    }
}