namespace Monads.Core.MaybeMonad;

public interface IMaybe<out T> 
{
    TNext Match<TNext>(Func<T, TNext> some, Func<TNext> none);
    
    IMaybe<TNext> Map<TNext>(Func<T, TNext> func);
    
    IMaybe<TU> Bind<TU>(Func<T, IMaybe<TU>> func);
}