using NUnit.Framework;
using System;
using System.Collections;

namespace PI_approximation
{
    public class PiApprox
    {
        public static ArrayList iterPi(double epsilon)
        {
            double iter = (double)(1/epsilon);
            double pi = 0;
            double sign = 1;            
            
            for (double i = 0; i < 1/epsilon; i++)
            {
                pi += sign / (2 * i + 1);
                sign = -sign;
            }
            double resPI = 4 * pi;
            double er = Math.Round(resPI, 10);           
            ArrayList res = new ArrayList() {iter, er};
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList r = PiApprox.iterPi(0.1);
            ArrayList c = new ArrayList { 10, 3.0418396189 };
            Assert.AreEqual(c, r);
        }
    }
}
