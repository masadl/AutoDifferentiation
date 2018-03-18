using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DualNumber.DualNumberTest
{
    [TestClass]
    public class DualNumberTest
    {
        [TestMethod]
        public void SummationDiff()
        {
            DualNumber c = new DualNumber(2, 1);
            Assert.AreEqual((f1(c) + f2(c)).FPrime, SummationDiffExpected(c.F));
        }

        private DualNumber f1(DualNumber x)
        {
            return x * x + new DualNumber(2) * x + new DualNumber(1);
        }

        private DualNumber f2(DualNumber x)
        {
            return x * x * x + x;
        }

        private double SummationDiffExpected(double x)
        {
            return 3 * x * x + 2 * x + 3;
        }
    }
}
