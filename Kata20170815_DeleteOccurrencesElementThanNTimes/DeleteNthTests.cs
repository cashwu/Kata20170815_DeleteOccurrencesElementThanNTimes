using System;
using System.Collections;
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

        private static void DeleteNthShouldBe(int[] expected, int[] array, int time)
        {
            var kata = new Kata();
            var actual = kata.DeleteNth(array, time);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int[] DeleteNth(int[] arr, int x)
        {
            return arr.Distinct().ToArray();
        }
    }
}
