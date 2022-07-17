namespace Monads.Core.MaybeMonad;

public interface IMaybe<out T> 
{
    TNext Match<TNext>(Func<T, TNext> some, Func<TNext> none);
    
    IMaybe<TNext> Map<TNext>(Func<T, TNext> func);
    
    IMaybe<TNext> Bind<TNext>(Func<T, IMaybe<TNext>> func);
}