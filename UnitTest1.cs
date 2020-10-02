using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReduceTest()
        {
            Fraction f1 = new Fraction(2, 8);
            Assert.AreEqual(1, f1.Numerator);
            Assert.AreEqual(4, f1.Denominator);
        }

        [TestMethod]
        public void GcfTest()
        {
            Fraction f1 = new Fraction(2, 8);
            int x = f1.Gcf(f1);
            Assert.AreEqual(2, x);
        }

        [TestMethod]
        public void GcfTest2()
        {
            Fraction f1 = new Fraction(8, 2);
            int x = f1.Gcf(f1);
            Assert.AreEqual(2, x);
        }

        [TestMethod]
        public void GcfTest3()
        {
            Fraction f1 = new Fraction(6, 21);
            int x = f1.Gcf(f1);
            Assert.AreEqual(3, x);
        }

        [TestMethod]
        public void GcfTest4()
        {
            Fraction f1 = new Fraction(7, 19);
            int x = f1.Gcf(f1);
            Assert.AreEqual(1, x);
        }

        [TestMethod]
        public void GcfTest5()
        {
            Fraction f1 = new Fraction(-2, 8);
            int x = f1.Gcf(f1);
            Assert.AreEqual(2, x);
        }

        [TestMethod]
        public void GcfTest6()
        {
            Fraction f1 = new Fraction(2, -8);
            int x = f1.Gcf(f1);
            Assert.AreEqual(2, x);
        }

        [TestMethod]
        public void LCMTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 9);
            int lcm = Fraction.Lcm(f1, f2);
            Assert.AreEqual(18, lcm);
        }

        [TestMethod]
        public void LCMTest2()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 2);
            int lcm = Fraction.Lcm(f1, f2);
            Assert.AreEqual(2, lcm);
        }

        [TestMethod]
        public void LCMTest3()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            int lcm = Fraction.Lcm(f1, f2);
            Assert.AreEqual(4, lcm);
        }
        
        [TestMethod]
        public void AdditionTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 9);
            Fraction f3 = f1 + f2;
            Assert.AreEqual(new Fraction(5/6), f3 );
        }

        [TestMethod]
        public void AdditionTest2()
        {
            Fraction f1 = new Fraction(1, 2);
            int x = 4;
            Fraction f2 = f1 + x; 
            Assert.AreEqual(new Fraction(9/2), f2);
        }

        [TestMethod]
        public void SubtractTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 9);
            Fraction f3 = f1 - f2;
            Assert.AreEqual(new Fraction(1 / 6), f3);
        }

        [TestMethod]
        public void SubtractTest2()
        {
            Fraction f1 = new Fraction(1, 2);
            int x = 4;
            Fraction f2 = f1 - x;
            Assert.AreEqual(new Fraction(-7 / 2), f2);
        }

        [TestMethod]
        public void MultTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 9);
            Fraction f3 = f1 * f2;
            Assert.AreEqual(1, f3.Numerator);
            Assert.AreEqual(6, f3.Denominator);
        }

        [TestMethod]
        public void MultTest2()
        {
            Fraction f1 = new Fraction(1, 2);
            int x = 4;
            Fraction f2 = f1 * x; 
            Assert.AreEqual(new Fraction(2 / 1), f2);
        }

        [TestMethod]
        public void DivideTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 9);
            Fraction f3 = f1 / f2; 
            Assert.AreEqual(new Fraction(3 / 2), f3);
        }

        [TestMethod]
        public void DivideTest2()
        {
            Fraction f1 = new Fraction(1, 2);
            int x = 4;
            Fraction f2 = f1 / x;
            Assert.AreEqual(new Fraction(1 / 8), f2);
        }

        [TestMethod]
        public void NegTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = -f1;
            Assert.AreEqual(new Fraction(-1 / 2), f2);
        }

        [TestMethod]
        public void NegTest2()
        {
            Fraction f1 = new Fraction(-1, 2);
            Fraction f2 = -f1;
            Assert.AreEqual(new Fraction(1 / 2), f2);
        }

        [TestMethod]
        public void NegTest3()
        {
            Fraction f1 = new Fraction(1, -2);
            Fraction f2 = -f1;
            Assert.AreEqual(new Fraction(1 / 2), f2);
        }

        [TestMethod]
        public void NegTest4()
        {
            Fraction f1 = new Fraction(-1, -2);
            Fraction f2 = -f1;
            Assert.AreEqual(new Fraction(1 / -2), f2);
        }        

        [TestMethod]
        public void GreaterTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Assert.IsFalse(f1 > f2);
        }

        [TestMethod]
        public void GreaterTest1()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Assert.IsTrue(f2 > f1);
        }

        [TestMethod]
        public void GreaterTest2()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);
            Assert.IsFalse(f1 > f2);
        }

        [TestMethod]
        public void LesserTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Assert.IsTrue(f1 < f2);
        }

        [TestMethod]
        public void LesserTest1()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Assert.IsFalse(f2 < f1);
        }

        [TestMethod]
        public void LesserTest2()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);
            Assert.IsFalse(f1 > f2);
        }

        [TestMethod]
        public void GreaterEqualTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Assert.IsFalse(f1 >= f2);
        }

        [TestMethod]
        public void GreaterEqualTest1()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Assert.IsTrue(f2 >= f1);
        }

        [TestMethod]
        public void GreaterEqualTest2()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);
            Assert.IsTrue(f1 >= f2);
        }

        [TestMethod]
        public void LesserEqualTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Assert.IsTrue(f1 <= f2);
        }

        [TestMethod]
        public void LesserEqualTest1()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Assert.IsFalse(f2 <= f1);
        }

        [TestMethod]
        public void LesserEqualTest2()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);
            Assert.IsTrue(f1 >= f2);
        }

        [TestMethod]
        public void EqualTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(2, 4);
            Assert.IsTrue(f1 == f2);
        }

        [TestMethod]
        public void EqualTest1()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);
            Assert.IsFalse(f2 == f1);
        }

        [TestMethod]
        public void NotEqualTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);
            Assert.IsFalse(f1 != f2);
        }

        [TestMethod]
        public void NotEqualTest1()
        {
            Fraction f1 = new Fraction(1, 4);
            Fraction f2 = new Fraction(6, 24);
            Assert.IsFalse(f1 != f2);
        }

        [TestMethod]
        public void NotEqualTest2()
        {
            Fraction f1 = new Fraction(1, 7);
            Fraction f2 = new Fraction(6, 24);
            Assert.IsTrue(f1 != f2);
        }

        [TestMethod]
        public void CastDoubleTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Assert.AreEqual(0.5 ,(double)f1);
        }

        [TestMethod]
        public void CastIntTest()
        {
            Fraction f1 = new Fraction(1, 2);
            Assert.AreEqual(0, (int)f1);
        }

        [TestMethod]
        public void CastIntTest1()
        {
            Fraction f1 = new Fraction(8, 2);
            Assert.AreEqual(4, (int)f1);
        }

        [TestMethod]
        public void CastFracTest()
        {
            int x = 4;
            Fraction f1 = new Fraction(4, 1);
            Assert.IsTrue(f1 == x);
        }
    }
}
