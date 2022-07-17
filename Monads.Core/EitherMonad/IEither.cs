namespace Monads.Core.EitherMonad;

public interface IEither<out TL, out TR>
{
    T Match<T>(Func<TL, T> onLeft, Func<TR, T> onRight);
}