using System;
using Monads.Core.EitherMonad;
using Monads.Core.MaybeMonad;
using Monads.Example.Core.City.Conference.Talk.Speaker;

namespace Monads.Example.EitherExamples;

public static class EitherExample
{
    public static void EitherComposition()
    {
        Console.WriteLine("Testing Either: ");
        var eitherErrorOrSpeaker1 = new Right<Exception, IMaybe<Speaker>>(Maybe<Speaker>.Factory(new Speaker()));
        var eitherErrorOrSpeaker2 = new Left<Exception, IMaybe<Speaker>>(new NotImplementedException("Hello there.."));
            
        // var eitherErrorOrSpeaker3 = eitherErrorOrSpeaker1.Bind()
        ShowSpeaker(eitherErrorOrSpeaker1);
        ShowSpeaker(eitherErrorOrSpeaker2);
    }

    private static void ShowSpeaker(IEither<Exception, IMaybe<Speaker>> speakerResult)
    {
        var speaker = speakerResult.Match(
            left =>
            {
                Console.WriteLine(left);
                return Maybe<Speaker>.Factory(null);
            },
            right => right);
        Console.WriteLine(speaker);
    }
}