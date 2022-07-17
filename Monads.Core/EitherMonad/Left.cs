namespace Monads.Core.EitherMonad;

public class Left<TL, TR> : IEither<TL, TR>
{
    private readonly TL _left;
    
    public Left(TL left)
    {
        _left = left;
    }
    
    public T Match<T>(Func<TL, T> onLeft, Func<TR, T> onRight)
    {
        return onLeft(_left);
    }
}