using Xunit;

namespace Tddbc.Test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void _1を渡すと文字列1を返す()
        {
            // 準備
            FizzBuzz fuzzbuzz = new FizzBuzz();

            // 実行
            string actual = fuzzbuzz.Convert(1);

            // 検証
            Assert.Equal("1", actual);
        }
    }
}
