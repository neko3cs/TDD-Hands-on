using Xunit;

namespace Tddbc.Test
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void ���𕶎���ɕϊ�����(int num, string expected)
        {
            // ����
            FizzBuzz fizzBuzz = new FizzBuzz();

            // ���s
            // ����
            Assert.Equal(expected, fizzBuzz.Convert(num));
        }
    }
}
