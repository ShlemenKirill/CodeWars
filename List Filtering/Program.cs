using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Filtering
{
    class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //List<object> list = new List<object>();
            List<int> list = new List<int>();
            foreach (var aPart in listOfItems)
            {                
                if (aPart.GetType() == typeof(Int32))
                {
                    list.Add(Convert.ToInt32(aPart));
                }               

            }           
               
            return list;
        }
        static void Main(string[] args)
        {
            var list = new List<object>() { 1, 2, "a", "b" };
            var expected = new List<int>() { 1, 2 };
            var actual = ListFilterer.GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
            Console.WriteLine("Hello World!");
        }
    }
}
