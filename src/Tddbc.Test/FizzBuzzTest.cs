using Xunit;

namespace Tddbc.Test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void _1��n���ƕ�����1��Ԃ�()
        {
            // ����
            FizzBuzz fizzBuzz = new FizzBuzz();

            // ���s
            // ����
            Assert.Equal("1", fizzBuzz.Convert(1));
        }

        [Fact]
        public void _2��n���ƕ�����2��Ԃ�()
        {
            // ����
            FizzBuzz fizzBuzz = new FizzBuzz();

            // ���s
            // ����
            Assert.Equal("2", fizzBuzz.Convert(2));
        }
    }
}
