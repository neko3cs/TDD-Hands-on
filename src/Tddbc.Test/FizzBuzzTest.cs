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
            string actual = fizzBuzz.Convert(1);

            // ����
            Assert.Equal("1", actual);
        }
    }
}
