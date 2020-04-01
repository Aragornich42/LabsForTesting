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
            Assert.IsTrue(finalList.Any(num => num == 132));
            Assert.IsFalse(finalList.Any(num => num == 111));
        }

        [TestMethod]
        public void GetMaxTest()
        {
            var list1 = new List<int>();
            var list2 = new List<int> { 1 };
            var list3 = new List<int> { 1, 2, 3, 4, 5 };

            var result1 = Common.GetMaxOrMin(list1, WhatFind.Max);
            var result2 = Common.GetMaxOrMin(list2, WhatFind.Max);
            var result3 = Common.GetMaxOrMin(list3, WhatFind.Max);

            Assert.AreEqual(int.MaxValue, result1, $"result of empty array when find max must be {int.MaxValue}, now {result1}");
            Assert.AreEqual(1, result2, $"result of one elem array when find max must be 1, now {result2}");
            Assert.AreEqual(5, result3, $"result of five elem array when find max must be 5, now {result3}");
        }

        [TestMethod]
        public void GetMinTest()
        {
            var list1 = new List<int>();
            var list2 = new List<int> { 1 };
            var list3 = new List<int> { 1, 2, 3, 4, 5 };

            var result1 = Common.GetMaxOrMin(list1, WhatFind.Min);
            var result2 = Common.GetMaxOrMin(list2, WhatFind.Min);
            var result3 = Common.GetMaxOrMin(list3, WhatFind.Min);

            Assert.AreEqual(int.MaxValue, result1, $"result of empty array when find min must be {int.MaxValue}, now {result1}");
            Assert.AreEqual(1, result2, $"result of one elem array when find min must be 1, now {result2}");
            Assert.AreEqual(1, result3, $"result of five elem array when find min must be 1, now {result3}");
        }
    }
}
