using System;
using System.Collections.Generic;

namespace array_dotnet
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var firstNumlist = new List<int>();
            firstNumlist.Add(1);
            firstNumlist.Add(2);
            firstNumlist.Add(8);
            firstNumlist.Add(7);
            firstNumlist.Add(9);
            firstNumlist.Add(13);
            firstNumlist.Add(16);
        }

        public static int countMults(int[] nums, int divisibility)
        {
            var divisibleCount = 0;

            foreach (var item in nums)
            {
                if (item % divisibility == 0)
                {
                    divisibleCount++;
                }
            }
            return divisibleCount;
        }

        publlc static bool hasThreNoneAdjacentThrees(int[] nums) 
        {
            return true; 
        } 

        public static bool containsString(char[] letters, string word)
        {
            return true;
        }

    }
}
