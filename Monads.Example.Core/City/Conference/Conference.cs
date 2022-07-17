using Monads.Core.MaybeMonad;

namespace Monads.Example.Core.City.Conference;

public class Conference
{
    public IMaybe<City> GetCity()
    {
        var city = new City();
        return Maybe<City>.Factory(city);
    }
}