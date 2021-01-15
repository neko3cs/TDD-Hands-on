using FluentAssertions;
using Xunit;

namespace Tddbc.Test
{
    namespace FizzBuzzTest
    {
        public class Convert���\�b�h�͐��𕶎���ɕϊ�����
        {
            private readonly FizzBuzz _fizzBuzz;

            public Convert���\�b�h�͐��𕶎���ɕϊ�����()
            {
                _fizzBuzz = new FizzBuzz();
            }

            [Theory]
            [InlineData(3)]
            [InlineData(6)]
            public void _3�̔{���̎��͐��̑����Fizz�ƕϊ�����(int num)
            {
                _fizzBuzz.Convert(num).Should().Be("Fizz");
            }

            [Theory]
            [InlineData(5)]
            [InlineData(10)]
            public void _5�̔{���̎��͐��̑����Buzz�ƕϊ�����(int num)
            {
                _fizzBuzz.Convert(num).Should().Be("Buzz");
            }

            [Theory]
            [InlineData(15)]
            [InlineData(30)]
            public void _15�̔{���̎��͐��̑����FizzBuzz�ƕϊ�����(int num)
            {
                _fizzBuzz.Convert(num).Should().Be("FizzBuzz");
            }

            [Theory]
            [InlineData(1, "1")]
            [InlineData(2, "2")]
            public void ���̑��̐��̏ꍇ�͂��̂܂ܕ�����ɕϊ�����(int num, string expected)
            {
                _fizzBuzz.Convert(num).Should().Be(expected);
            }
        }
    }
}
