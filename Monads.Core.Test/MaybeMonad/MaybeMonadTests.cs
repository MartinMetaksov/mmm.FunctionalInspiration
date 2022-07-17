using Monads.Core.MaybeMonad;

namespace Monads.Core.Test.MaybeMonad;

public class MaybeMonadTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void LeftIdentityLaw_Test(int input)
    {
        IMaybe<int> Return(int i) => Maybe<int>.Factory(i);
        IMaybe<double> Func(int i) => i != 0 ? Maybe<double>.Factory(1.0 / i) : new Nothing<double>();
        
        Assert.True(Return(input).Bind(Func).Equals(Func(input)));
    }

    [Theory]
    [InlineData("")]
    [InlineData("abc")]
    [InlineData("123")]
    [InlineData("0.1")]
    [InlineData("-1")]
    public void RightIdentityLaw_Test(string input)
    {
        IMaybe<int> Return(int i) => Maybe<int>.Factory(i);
        IMaybe<int> Func(string s) => int.TryParse(s, out var i) ? Maybe<int>.Factory(i) : new Nothing<int>();
        var m = Func(input);
        
        Assert.True(m.Bind(Return).Equals(m));
    }
    
    [Theory]
    [InlineData("abc")]
    [InlineData("-1")]
    [InlineData("0")]
    [InlineData("4")]
    public void AssociativityLaw_Test(string input)
    {
        IMaybe<int> Func(string s) => int.TryParse(s, out var i) ? Maybe<int>.Factory(i) : new Nothing<int>();
        IMaybe<double> G(int i) => Maybe<double>.Factory(Math.Sqrt(i));
        IMaybe<double> H(double d) => d == 0 ? new Nothing<double>() : Maybe<double>.Factory(1 / d);
        var m = Func(input);
        
        Assert.True(m.Bind(G).Bind(H).Equals(m.Bind(mResult => G(mResult).Bind(H))));
    }
}