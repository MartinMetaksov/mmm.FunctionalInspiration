using Monads.Core.MaybeMonad;

namespace Monads.Example.Core.City.Conference.Talk.Speaker;

public class Speaker
{
    public IMaybe<Talk> NextTalk()
    {
        var talk = new Talk();
        return Maybe<Talk>.Factory(talk);
    }
}