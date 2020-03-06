using LabsForTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CountLessThen5BinaryUnitsTest()
        {
            var finalList = new List<int>();
            var list1 = new List<int> { 1, 2, 3, 4, 5, 154, 111, 132, 2453, 23412 };

            var result1 = Common.CountLessThen5BinaryUnits(list1, out finalList);
            Assert.AreEqual(7, result1, $"Количество чисел должно быть равно 7, а сейчас равно {result1}");
            Assert.IsNotNull(finalList);
            Assert.IsTrue(finalList.Any(num => num == 132));
            Assert.IsFalse(finalList.Any(num => num == 111));
        }

        [TestMethod]
        public void GetMaxOrMinTest()
        {
            var list1 = new List<int>();
            var list2 = new List<int> { 1 };
            var list3 = new List<int> { 1, 2, 3, 4, 5 };

            var result1_1 = Common.GetMaxOrMin(list1, WhatFind.Max);
            var result1_2 = Common.GetMaxOrMin(list1, WhatFind.Min);
            var result2_1 = Common.GetMaxOrMin(list2, WhatFind.Max);
            var result2_2 = Common.GetMaxOrMin(list2, WhatFind.Min);
            var result3_1 = Common.GetMaxOrMin(list3, WhatFind.Max);
            var result3_2 = Common.GetMaxOrMin(list3, WhatFind.Min);

            Assert.AreEqual(int.MaxValue, result1_1, $"result of empty array when find max must be {int.MaxValue}, now {result1_1}");
            Assert.AreEqual(int.MaxValue, result1_2, $"result of empty array when find min must be {int.MaxValue}, now {result1_2}");
            Assert.AreEqual(1, result2_1, $"result of empty array when find max must be 1, now {result2_1}");
            Assert.AreEqual(1, result2_2, $"result of empty array when find min must be 1, now {result2_2}");
            Assert.AreEqual(5, result3_1, $"result of empty array when find max must be 5, now {result3_1}");
            Assert.AreEqual(1, result3_2, $"result of empty array when find min must be 1, now {result3_2}");
        }
    }
}
