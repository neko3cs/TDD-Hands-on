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

        [Theory]
        [InlineData(3)]
        public void _3‚Ì”{”‚Ì‚Í”‚Ì‘ã‚í‚è‚ÉFizz‚Æ•ÏŠ·‚·‚é(int num)
        {
            _fizzBuzz.Convert(num).Should().Be("Fizz");
        }

        [Theory]
        [InlineData(5)]
        public void _5‚Ì”{”‚Ì‚Í”‚Ì‘ã‚í‚è‚ÉBuzz‚Æ•ÏŠ·‚·‚é(int num)
        {
            _fizzBuzz.Convert(num).Should().Be("Buzz");
        }
    }
}
