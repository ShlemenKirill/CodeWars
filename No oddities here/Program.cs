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
            Console.WriteLine("Hello World!");
        }
    }
}
