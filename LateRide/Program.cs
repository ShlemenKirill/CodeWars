using NUnit.Framework;
using System;

namespace LateRide
{
    class Kata
    {
        public int LateRide(int n)
        {
            int hours = n/60;
            int min = n%60;
            
            if (hours % 10 != 0)
            {
                hours = hours / 10 +hours%10;
            }
            else
            {
                hours /= 10;
            }

            if (min % 10 != 0)
            {
                min = min / 10 + min % 10;
            }
            else
            {
                min /= 10;
            }
            int sum = hours + min;
            return sum;
        }
        static void Main(string[] args)
        {
            var kata = new Kata();

            Assert.AreEqual(9, kata.LateRide(1207), "");

            Assert.AreEqual(14, kata.LateRide(808), "");

            Assert.AreEqual(19, kata.LateRide(1439), "");

            Assert.AreEqual(0, kata.LateRide(0), "");

            Assert.AreEqual(5, kata.LateRide(23), "");

            Assert.AreEqual(8, kata.LateRide(8), "");
        }
    }
}
