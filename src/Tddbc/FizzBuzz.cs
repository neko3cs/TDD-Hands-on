﻿using System;

namespace Tddbc
{
    public class FizzBuzz
    {
        public string Convert(int num)
        {
            if (num % 3 is 0)
            {
                return "Fizz";
            }
            return num.ToString();
        }
    }
}
