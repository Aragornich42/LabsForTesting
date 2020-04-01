using LabsForTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class IntegrationTests
    {

        [TestMethod]
        public void CheckTenDigitsArrayMax()
        {
            var finalList = new List<int>();
            var list = new List<int> { 1, 2, 3, 4, 5, 154, 111, 132, 2453, 23412 };

            var result1 = Common.CountLessThen5BinaryUnits(list, out finalList);
            Assert.AreEqual(7, result1, $"Количество чисел должно быть равно 7, а сейчас равно {result1}");
            Assert.IsTrue(finalList.Any(num => num == 132));
            Assert.IsFalse(finalList.Any(num => num == 111));

            var result = Common.GetMaxOrMin(finalList, WhatFind.Max);
            Assert.AreEqual(154, result, $"result of empty array when find min must be 154, now {result}");
        }

        [TestMethod]
        public void CheckTenDigitsArrayMin()
        {
            var finalList = new List<int>();
            var list = new List<int> { 1, 2, 3, 4, 5, 154, 111, 132, 2453, 23412 };

            var result1 = Common.CountLessThen5BinaryUnits(list, out finalList);
            Assert.AreEqual(7, result1, $"Количество чисел должно быть равно 7, а сейчас равно {result1}");
            Assert.IsTrue(finalList.Any(num => num == 132));
            Assert.IsFalse(finalList.Any(num => num == 111));

            var result = Common.GetMaxOrMin(finalList, WhatFind.Min);
            Assert.AreEqual(1, result, $"result of ten elems array when find min must be 1, now {result}");
        }

        [TestMethod]
        public void CheckZeroDigitsArray()
        {
            var list = new List<int>();

            var result1 = Common.CountLessThen5BinaryUnits(list, out var finalList);
            Assert.AreEqual(0, result1, $"Количество чисел должно быть равно 0, а сейчас равно {result1}");
            Assert.IsNotNull(finalList, "Итоговый массив finalList не должен быть null");
            Assert.AreEqual(0, finalList.Count, "Итоговый массив finalList должен быть пуст");

            var result = Common.GetMaxOrMin(finalList, WhatFind.Max);
            Assert.AreEqual(int.MaxValue, result, $"result of empty array when find min must be {int.MaxValue}, now {result}");
        }

        [TestMethod]
        public void CheckOneDigitsArrayMax()
        {
            var list = new List<int> { 1 };

            var result1 = Common.CountLessThen5BinaryUnits(list, out var finalList);
            Assert.AreEqual(1, result1, $"Количество чисел должно быть равно 1, а сейчас равно {result1}");
            Assert.IsNotNull(finalList, "Итоговый массив finalList не должен быть null");
            Assert.AreEqual(1, finalList.Count, "Итоговый массив finalList не должен быть пуст");

            var result = Common.GetMaxOrMin(finalList, WhatFind.Max);
            Assert.AreEqual(1, result, $"result of one elem array when find min must be 1, now {result}");
        }

    }
}
