using System;
using System.Collections.Generic;
using Monads.Core.MaybeMonad;
using Monads.Example.Core.City.Conference.Talk.Speaker;

namespace Monads.Example.MaybeExamples;

public static class MaybeExample
{
    public static void MaybeComposition() {
        Console.WriteLine("Maybe Composition: ");
        var city = Maybe<Speaker>.Factory(new Speaker())
            .Bind(speaker => speaker.NextTalk())
            .Bind(talk => talk.GetConference())
            .Bind(conference => conference.GetCity());
        Console.WriteLine($"Maybe Composition Completed; retrieved city: {city}");
    }

    public static void EnumerableExtensions() {
        var speaker1 = new Speaker();
        var speaker2 = new Speaker();
        var speaker3 = new Speaker();
        var speakers = new List<Speaker>() {speaker1, speaker2, speaker3};
        var firstSpeaker = speakers.MaybeFirst();
        var lastSpeaker = speakers.MaybeLast();
        var speakerAt = speakers.MaybeElementAt(1);
        var speakerAtNonExistentIndex = speakers.MaybeElementAt(999);
        var nonExistentCity = speakerAtNonExistentIndex
            .Bind(speaker => speaker.NextTalk())
            .Bind(talk => talk.GetConference())
            .Bind(conference => conference.GetCity());
        Console.WriteLine($"First speaker: {firstSpeaker}");
        Console.WriteLine($"Last speaker: {lastSpeaker}");
        Console.WriteLine($"Speaker at index: {speakerAt}");
        Console.WriteLine($"Speaker at non-existent index: {speakerAtNonExistentIndex}");
        Console.WriteLine($"Non-existing city, queried from a a non-existent speaker: {nonExistentCity}");
    }   
}