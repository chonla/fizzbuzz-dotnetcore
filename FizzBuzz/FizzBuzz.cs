using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Say(int v)
        {
            if (v % 3 == 0 && v % 5 == 0) {
                return "FizzBuzz";
            }
            if (v % 3 == 0)
            {
                return "Fizz";
            }
            if (v % 5 == 0)
            {
                return "Buzz";
            }
            return v.ToString();
        }
    }
}
