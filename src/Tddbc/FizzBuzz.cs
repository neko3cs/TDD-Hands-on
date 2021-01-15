using System;

namespace Tddbc
{
    public class FizzBuzz
    {
        public string Convert(int num)
        {
            if (num is 3)
            {
                return "Fizz";
            }
            return num.ToString();
        }
    }
}
