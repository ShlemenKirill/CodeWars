using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Find_the_first_non_consecutive_number
{
    class Kata
    {
        public static object FirstNonConsecutive(int[] arr)
        {
            
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (list.IndexOf(arr[i]) != arr[i-1])
                {
                    list.Add(arr[i]);
                    
                    
                }
                
            }
            return list.ToArray();
        }
        static void Main(string[] args)
        {
            Assert.AreEqual(6, Kata.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
           
        }
    }
}
