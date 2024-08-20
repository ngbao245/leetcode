using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS.Test
{
    [TestClass]
    public class _0650_2KeysKeyboard_Test
    {
        private readonly _0650_2KeysKeyboard.Solution solution = new _0650_2KeysKeyboard.Solution();

        [TestMethod]
        public void MinSteps_Input1_ShouldReturn0()
        {
            int n = 15;
            int expected = 8;
            int result = solution.MinSteps(n);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MinSteps_Input3_ShouldReturn3()
        {
            int n = 3;
            int expected = 3;
            int result = solution.MinSteps(n);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MinSteps_Input9_ShouldReturn6()
        {
            int n = 9;
            int expected = 6;
            int result = solution.MinSteps(n);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MinSteps_Input10_ShouldReturn7()
        {
            int n = 10;
            int expected = 7;
            int result = solution.MinSteps(n);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MinSteps_Input15_ShouldReturn8()
        {
            int n = 15;
            int expected = 8;
            int result = solution.MinSteps(n);
            Assert.AreEqual(expected, result);
        }
    }
}
