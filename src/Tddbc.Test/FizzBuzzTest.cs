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
        public void ���𕶎���ɕϊ�����(int num, string expected)
        {
            _fizzBuzz.Convert(num).Should().Be(expected);
        }

        [Fact]
        public void _3��n���ƕ�����Fizz��Ԃ�()
        {
            _fizzBuzz.Convert(3).Should().Be("Fizz");
        }

        [Fact]
        public void _5��n���ƕ�����Buzz��Ԃ�()
        {
            _fizzBuzz.Convert(5).Should().Be("Buzz");
        }
    }
}
