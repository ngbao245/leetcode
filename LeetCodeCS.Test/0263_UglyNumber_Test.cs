using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCS.Test
{
    [TestClass]
    public class _0263_UglyNumber_Test
    {
        private readonly _0263_UglyNumber.Solution solution = new _0263_UglyNumber.Solution();

        [TestMethod]
        public void Test_UglyNumber_6()
        {
            int n = 6;
            bool result = solution.IsUgly(n);
            Assert.IsTrue(result, $"Expected true, but got {result} for n = {n}");
        }

        [TestMethod]
        public void Test_UglyNumber_1()
        {
            int n = 1;
            bool result = solution.IsUgly(n);
            Assert.IsTrue(result, $"Expected true, but got {result} for n = {n}");
        }

        [TestMethod]
        public void Test_UglyNumber_14()
        {
            int n = 14;
            bool result = solution.IsUgly(n);
            Assert.IsFalse(result, $"Expected false, but got {result} for n = {n}");
        }

        [TestMethod]
        public void Test_UglyNumber_0()
        {
            int n = 0;
            bool result = solution.IsUgly(n);
            Assert.IsFalse(result, $"Expected false, but got {result} for n = {n}");
        }

        [TestMethod]
        public void Test_UglyNumber_Negative()
        {
            int n = -6;
            bool result = solution.IsUgly(n);
            Assert.IsFalse(result, $"Expected false, but got {result} for n = {n}");
        }

    }
}
