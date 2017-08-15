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
            var dic = new Dictionary<int, int>();
            var result = new List<int>();
            foreach (var item in arr)
            {
                if (dic.ContainsKey(item))
                {
                    if (dic[item] >= time)
                    {
                        continue;
                    }

                    dic[item] = dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }

                result.Add(item);
            }

            return result.ToArray();
        }
    }
}
