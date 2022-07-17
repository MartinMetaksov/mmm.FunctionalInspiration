using System;
using Monads.Example.MaybeExamples;
using Monads.Example.EitherExamples;

namespace Monads.Example;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("--------");
        MaybeExample.MaybeComposition();
        Console.WriteLine("--------");
        MaybeExample.EnumerableExtensions();
        Console.WriteLine("--------");
        EitherExample.EitherComposition();
    }
}