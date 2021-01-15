using FluentAssertions;
using Xunit;

namespace Tddbc.Test
{
    public class FizzBuzzTest
    {
        private FizzBuzz _fizzBuzz;
        
        public FizzBuzzTest()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void 数を文字列に変換する(int num, string expected)
        {
            _fizzBuzz.Convert(num).Should().Be(expected);
        }

        [Fact]
        public void _3を渡すと文字列Fizzを返す()
        {
            _fizzBuzz.Convert(3).Should().Be("Fizz");
        }

        [Fact]
        public void _5を渡すと文字列Buzzを返す()
        {
            _fizzBuzz.Convert(5).Should().Be("Buzz");
        }
    }
}
