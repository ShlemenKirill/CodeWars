using System;
using System.Collections.Generic;

namespace How_good_are_you_really
{
    class Program
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            int average = 0;
            int length = ClassPoints.Length;            
            
            for (int i = 0; i < ClassPoints.Length; i++)
            {
                average =+ ClassPoints[i];
                
            }

            if ((average + YourPoints)/(length) < YourPoints)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
