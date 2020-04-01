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
            var interpretations = ConvertToBinary(nums);
            finalNums = interpretations.Where(interp => IsLessThen5BinaryUnits(interp.Binary)).Select(interp => interp.Decimal).ToList();
            return finalNums.Count;
        }

        private static List<NumberInterpretations> ConvertToBinary(List<int> nums)
        {
            return nums.Select(num => new NumberInterpretations { Decimal = num, Binary = Convert.ToString(num, 2) }).ToList();
        }
        

        private static bool IsLessThen5BinaryUnits(string num)
        {
            return new Regex(@"(1)").Matches(num).Count < 5;
            //return (num.Length - num.Replace("1", "").Length) < 5;
        }

    }
}
