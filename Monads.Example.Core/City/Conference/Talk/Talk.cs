using Monads.Core.MaybeMonad;

namespace Monads.Example.Core.City.Conference.Talk;

public class Talk
{
    public IMaybe<Conference> GetConference()
    {
        var conference = new Conference();
        return Maybe<Conference>.Factory(conference);
    }
}