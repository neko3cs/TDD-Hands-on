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
        public void ”‚ğ•¶š—ñ‚É•ÏŠ·‚·‚é(int num, string expected)
        {
            _fizzBuzz.Convert(num).Should().Be(expected);
        }

        [Fact]
        public void _3‚ğ“n‚·‚Æ•¶š—ñFizz‚ğ•Ô‚·()
        {
            _fizzBuzz.Convert(3).Should().Be("Fizz");
        }

        [Fact]
        public void _5‚ğ“n‚·‚Æ•¶š—ñBuzz‚ğ•Ô‚·()
        {
            _fizzBuzz.Convert(5).Should().Be("Buzz");
        }
    }
}
