using System;

namespace Square_n__Sum
{
    class Program
    {
        public static int SquareSum(int[] n)
        {
            double res = 0;
            for (int i = 0; i < n.Length; i++)
            {                
                res += Math.Pow(n[i],2);
            }        
                        
            return (int)res;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }
}
