using FluentAssertions;
using Xunit;

namespace Tddbc.Test
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void ”‚ğ•¶š—ñ‚É•ÏŠ·‚·‚é(int num, string expected)
        {
            // €”õ
            FizzBuzz fizzBuzz = new FizzBuzz();

            // Às
            // ŒŸØ
            fizzBuzz.Convert(num).Should().Be(expected);
        }
    }
}
