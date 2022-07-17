namespace Monads.Core.EitherMonad;

public class Right<TL, TR> : IEither<TL, TR>
{
    private readonly TR _right;
    
    public Right(TR right)
    {
        _right = right;
    }
    
    public T Match<T>(Func<TL, T> onLeft, Func<TR, T> onRight)
    {
        return onRight(_right);
    }
}