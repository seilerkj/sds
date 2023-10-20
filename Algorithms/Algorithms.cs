using System;
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            int count = 1;

        for (int i = n; i > 0; i--)
            {

                count *= i ;    
            }

            return count;
        }

        public static string FormatSeparators(params string[] items)

        {

            var str =  $"{string.Join(", ", items.SkipLast(1))} and {items.Last()}";

            return str;
        }
    }
}