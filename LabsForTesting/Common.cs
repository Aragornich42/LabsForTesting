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

        public static int CountLessThen5BinaryUnits(List<int> nums, out List<int> finalNums)
        {
            var binariesDict = ConvertToBinary(nums);
            var finalDict = new Dictionary<int, string>();

            foreach(int num in binariesDict.Keys)
            {
                if (IsLessThen5BinaryUnits(binariesDict[num]))
                    finalDict.Add(num, binariesDict[num]);
            }

            finalNums = finalDict.Keys.ToList();
            return finalDict.Count;
        }

        private static Dictionary<int, string> ConvertToBinary(List<int> nums)
        {
            return nums.ToDictionary(num => num, num => Convert.ToString(num, 2));
        }
        

        private static bool IsLessThen5BinaryUnits(string num)
        {
            return new Regex(@"(1)").Matches(num).Count < 5;
            //return (num.Length - num.Replace("1", "").Length) < 5;
        }

    }
}
