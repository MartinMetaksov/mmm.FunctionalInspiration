namespace Monads.Core.MaybeMonad;

public interface IMaybe<out T> 
{
    TNext Match<TNext>(Func<T, TNext> just, Func<TNext> nothing);
    
    IMaybe<TNext> Map<TNext>(Func<T, TNext> func);
    
    IMaybe<TNext> Bind<TNext>(Func<T, IMaybe<TNext>> func);

    bool Equals<TNext>(IMaybe<TNext> obj);
}