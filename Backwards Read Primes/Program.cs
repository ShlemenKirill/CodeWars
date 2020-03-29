using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Backwards_Read_Primes
{
    public class BackWardsPrime
    {

        public static string backwardsPrime(int start, int end)
        {
            string result = null;
            
            List<long> list = new List<long>();

            for (int i = 2; i < end; i++)
            {
                bool res = true;
                for (int j = 2; j < i; j++)
                {
                    
                    if (i%j == 0)
                    {
                        res = false;
                        break;
                    }
                    
                }
                if (res == true)
                {
                    list.Add(i);
                }


            }
            for (int k = 0; k < list.Count; k++)
            {
                Console.WriteLine(list[k]);
                Console.ReadKey();
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assert.AreEqual("13 17 31 37 71 73 79 97", BackWardsPrime.backwardsPrime(1, 100));
        }
    }
}
