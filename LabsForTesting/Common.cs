using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LabsForTesting
{
    public static class Common
    {

        public static int GetMaxOrMin(List<int> nums, WhatFind find)
        {
            if (nums.Count == 0)
                return int.MaxValue;

            if (nums.Count == 1)
                return nums.First();

            var copyList = new List<int>();
            copyList.AddRange(nums);
            copyList.Sort();
            return 
                find == 0 ?
                    copyList.Last() :
                    copyList.First();
        }

        public static int CountLessThen5BinaryUnits(List<int> nums)
        {
            var binaries = ConvertToBinary(nums);
            return binaries.Where(binary => IsLessThen5BinaryUnits(binary)).ToList().Count;
        }

        private static List<string> ConvertToBinary(List<int> nums) 
        { 
            return nums.Select(num => Convert.ToString(num, 2)).ToList(); 
        }
        

        private static bool IsLessThen5BinaryUnits(string num)
        {
            return new Regex(@"(1)").Matches(num).Count < 5;
        }

    }
}
