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
            firstNumlist.Add(3);
            firstNumlist.Add(1);
            firstNumlist.Add(3);
            firstNumlist.Add(1);
            firstNumlist.Add(3);
            firstNumlist.Add(13);
            firstNumlist.Add(3);
            var  myArray = firstNumlist.ToArray();
            Console.WriteLine(countMults(myArray, 2));
            Console.WriteLine(hasThreNonAdjacentThrees(myArray));
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

        public static bool hasThreNonAdjacentThrees(int[] nums) 
        {
            var threeCount = 0;
            foreach (var item in nums)
            {
                if (item == 3)
                {
                    threeCount++;
                }
            }
            if (threeCount != 3)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < nums.Length-1; i++)
                {
                    if (nums[i] == 3 && nums[i+1] == 3)
                    {
                        return false; 
                    }
                }
                return true;
            }
        } 

        public static bool containsString(char[] letters, string word)
        {
            return true;
        }

    }
}
