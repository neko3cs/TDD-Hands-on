using FluentAssertions;
using Xunit;

namespace Tddbc.Test
{
    namespace FizzBuzzTest
    {
        public class Convertメソッドは数を文字列に変換する
        {
            private readonly FizzBuzz _fizzBuzz;

            public Convertメソッドは数を文字列に変換する()
            {
                _fizzBuzz = new FizzBuzz();
            }

            [Theory]
            [InlineData(3)]
            [InlineData(6)]
            public void _3の倍数の時は数の代わりにFizzと変換する(int num)
            {
                _fizzBuzz.Convert(num).Should().Be("Fizz");
            }

            [Theory]
            [InlineData(5)]
            [InlineData(10)]
            public void _5の倍数の時は数の代わりにBuzzと変換する(int num)
            {
                _fizzBuzz.Convert(num).Should().Be("Buzz");
            }

            [Theory]
            [InlineData(15)]
            [InlineData(30)]
            public void _15の倍数の時は数の代わりにFizzBuzzと変換する(int num)
            {
                _fizzBuzz.Convert(num).Should().Be("FizzBuzz");
            }

            [Theory]
            [InlineData(1, "1")]
            [InlineData(2, "2")]
            public void その他の数の場合はそのまま文字列に変換する(int num, string expected)
            {
                _fizzBuzz.Convert(num).Should().Be(expected);
            }
        }
    }
}
