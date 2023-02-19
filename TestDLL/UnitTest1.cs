using WSUniversalLib;

namespace TestDLL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodIsNotNull()
        {
            Assert.IsNotNull(Calculation.GetQuantityForProduct(3, 1, 15, 20, 45));
        }
        [TestMethod]
        public void TestMethodIsInstanceOfType()
        {
            Int32 f = 0;
            Assert.IsInstanceOfType(Calculation.GetQuantityForProduct(3, 1, 15, 20, 45), f.GetType());
        }
        [TestMethod]
        public void TestMethodIsNotInstanceOfType()
        {
            string f = "a";
            Assert.IsNotInstanceOfType(Calculation.GetQuantityForProduct(3, 1, 15, 20, 45), f.GetType());
        }
        [TestMethod]
        public void TestMethodIsNotInstanceOfType2()
        {
            bool f = true;
            Assert.IsNotInstanceOfType(Calculation.GetQuantityForProduct(3, 1, 15, 20, 45), f.GetType());
        }
        [TestMethod]
        public void TestMethodIsFalse()
        {
            bool fact = true;
            if (Calculation.GetQuantityForProduct(3, 55, 15, 20, 45) == -1)
            {
                fact = false;
            }
            Assert.IsFalse(fact);
        }
        [TestMethod]
        public void TestMethodIsTrue()
        {
            bool fact = true;
            if (Calculation.GetQuantityForProduct(1, 1, 15, 20, 45) == -1)
            {
                fact = false;
            }
            Assert.IsTrue(fact);
        }

        [TestMethod]
        public void TestMethodEqualResult()
        {
            int fact = 114146;
            int expected = Calculation.GetQuantityForProduct(3, 1, 15, 20, 45);
            Assert.AreEqual(fact, expected);
        }

        [TestMethod]
        public void TestMethodNotEqualResult()
        {
            int fact = 1;
            int expected = Calculation.GetQuantityForProduct(3, 1, 15, 20, 45);
            Assert.AreNotEqual(fact, expected);
        }
        [TestMethod]
        public void TestMethodEqualResultIncorrectMaterialType()
        {
            int fact = -1;
            int expected = Calculation.GetQuantityForProduct(10, 1, 15, 20, 45);
            Assert.AreEqual(fact, expected);
        }

        [TestMethod]
        public void TestMethodNotEqualResultIncorrectMaterialType()
        {
            int fact = 0;
            int expected = Calculation.GetQuantityForProduct(-1, 1, 15, 20, 45);
            Assert.AreNotEqual(fact, expected);
        }

        [TestMethod]
        public void TestMethodEqualResultIncorrectWidth()
        {
            int fact = 0;
            int expected = Calculation.GetQuantityForProduct(3, 1, 15, 0, 45);
            Assert.AreEqual(fact, expected);
        }

        [TestMethod]
        public void TestMethodEqualResultIncorrectLength()
        {
            int fact = 0;
            int expected = Calculation.GetQuantityForProduct(3, 1, 15, 20, 0);
            Assert.AreEqual(fact, expected);
        }
    }
}