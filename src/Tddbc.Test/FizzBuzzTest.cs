using Xunit;

namespace Tddbc.Test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void _1��n���ƕ�����1��Ԃ�()
        {
            // ����
            FizzBuzz fuzzbuzz = new FizzBuzz();

            // ���s
            string actual = fuzzbuzz.Convert(1);

            // ����
            Assert.Equal("1", actual);
        }
    }
}
