using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Alternate_capitalization
{
    public static class Kata
    {
        public static string[] Capitalize(string s)
        {
            
            char[] ch = s.ToCharArray();
            List<string> listUpper = new List<string>();
            List<string> listLower = new List<string>();
            
            for (int i = 0; i < ch.Length; i++)
            {
                if (i%2 != 0)
                {                    
                    listUpper.Add(ch[i].ToString().ToLower());
                    listLower.Add(ch[i].ToString().ToUpper());
                }
                else
                {
                    listUpper.Add(ch[i].ToString().ToUpper());
                    listLower.Add(ch[i].ToString().ToLower());
                }
            }                   
            
            string[] res = new string[2] { String.Join("", listUpper), String.Join("", listLower) };

            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assert.AreEqual(new string[2] { "AbCdEf", "aBcDeF" }, Kata.Capitalize("abcdef"));
            Assert.AreEqual(new string[2] { "CoDeWaRs", "cOdEwArS" }, Kata.Capitalize("codewars"));
            Assert.AreEqual(new string[2] { "AbRaCaDaBrA", "aBrAcAdAbRa" }, Kata.Capitalize("abracadabra"));
            Assert.AreEqual(new string[2] { "CoDeWaRrIoRs", "cOdEwArRiOrS" }, Kata.Capitalize("codewarriors"));
        }
    }
}
