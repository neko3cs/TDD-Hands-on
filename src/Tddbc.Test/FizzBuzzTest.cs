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

        [Theory]
        [InlineData(3)]
        public void _3�̔{���̎��͐��̑����Fizz�ƕϊ�����(int num)
        {
            _fizzBuzz.Convert(num).Should().Be("Fizz");
        }

        [Theory]
        [InlineData(5)]
        public void _5�̔{���̎��͐��̑����Buzz�ƕϊ�����(int num)
        {
            _fizzBuzz.Convert(num).Should().Be("Buzz");
        }
    }
}
