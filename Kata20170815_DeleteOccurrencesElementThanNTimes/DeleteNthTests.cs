using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170815_DeleteOccurrencesElementThanNTimes
{
    [TestClass]
    public class DeleteNthTests
    {
        [TestMethod]
        public void input_1_2_1_and_1_should_return_1_2()
        {
            DeleteNthShouldBe(new[] {1, 2}, new[] {1, 2, 1}, 1);
        }

        [TestMethod]
        public void input_1_2_1_and_2_should_return_1_2()
        {
            DeleteNthShouldBe(new[] { 1, 2, 1 }, new[] { 1, 2, 1 }, 2);
        }

        [TestMethod]
        public void input_c1()
        {
            DeleteNthShouldBe(new[] { 20, 37, 21 }, new[] { 20, 37, 20, 21 }, 1);
        }

        [TestMethod]
        public void input_c2()
        {
            DeleteNthShouldBe(new[] { 1, 1, 3, 3, 7, 2, 2, 2 }, new[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);
        }

        private static void DeleteNthShouldBe(int[] expected, int[] array, int time)
        {
            var kata = new Kata();
            var actual = kata.DeleteNth(array, time);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int[] DeleteNth(int[] arr, int time)
        {
            var result = new List<int>();
            foreach (var item in arr)
            {
                if (result.Count(a => a == item) < time)
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
