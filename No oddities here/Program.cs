using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace No_oddities_here
{
    class Program
    {
        public static int[] NoOdds(int[] values)
        {

            List<int> list = new List<int>();
            for (int i = 0; i < values.Length; i++)
            {
                int value = values[i];
                if (value % 2 == 0)
                {
                    
                    list.Add(value);
                }
            }
            
            return list.ToArray();
        }
        static void Main(string[] args)
        {
            Assert.AreEqual(new int[] { 2, 4 }, Program.NoOdds(new int[] { 1, 2, 3, 4, 5 }));
            
        }
    }
}
