using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProtoBusiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoBusiness.Tests
{
    [TestClass()]
    public class MiscTests
    {
        [TestMethod()]
        [DynamicData(nameof(GetMissingNumberTestCase), DynamicDataSourceType.Method)]
        public void GetOneMissingIntegerTest(List<int> numbers, int expected)
        {
            var misc = new Misc();
            var actual = misc.GetOneMissingSequentialIntegerList(numbers);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> GetMissingNumberTestCase()
        {
            yield return new object[]
            {
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11},
                10
            };

            yield return new object[]
            {
                new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11},
                1
            };

            yield return new object[]
            {
                new List<int> { 3, 2, 11, 10, 9, 8, 7, 6, 5, 4},
                1
            };

            yield return new object[]
            {
                new List<int> { 1, 3 },
                2
            };
        }
    }
}