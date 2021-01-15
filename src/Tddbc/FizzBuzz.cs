namespace Tddbc
{
    public class FizzBuzz
    {
        public string Convert(int num)
        {
            if (num % 15 is 0)
            {
                return "FizzBuzz";
            }
            if (num % 3 is 0)
            {
                return "Fizz";
            }
            if (num % 5 is 0)
            {
                return "Buzz";
            }
            return num.ToString();
        }
    }
}
