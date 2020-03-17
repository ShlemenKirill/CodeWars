using NUnit.Framework;
using System;

namespace Breaking_chocolate_problem
{
    class Kata
    {
        public static int BreakChocolate(int n, int m)
        {
            if (n == 1 && m == 1)
            {
                return 0;
            }
            if ( m==0|| n==0)
            {
                return 0;
            }
            return n * m - 1;
        }
        static void Main(string[] args)
        {
            Assert.AreEqual(24, Kata.BreakChocolate(5, 5));
            Assert.AreEqual(0, Kata.BreakChocolate(1, 1));
        }
    }
}
