using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculation;

namespace MyCalcTest
{
    [TestClass]
    public class MyCalcTest
    {
        [TestMethod]
        public void A_1C_1X2Y4()
        {
            double a = -1, c = -1, x = 2, expected = 4;
            MyCalc calc = new MyCalc();
            double actual = calc.y(a, c, x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void A0C1X2Y_1()
        {
            double a = 0, c = 1, x = 2, expected = -1;
            MyCalc calc = new MyCalc();
            double actual = calc.y(a, c, x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void A2C1X5Y5()
        {
            double a = 2, c = 1, x = 5, expected = 5;
            MyCalc calc = new MyCalc();
            double actual = calc.y(a, c, x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void A0C_1X_3Y3()
        {
            double a = 0, c = -1, x = -3, expected = 3;
            MyCalc calc = new MyCalc();
            double actual = calc.y(a, c, x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void A1C1X1Y1()
        {
            double a = 1, c = 1, x = 1, expected = 1;
            MyCalc calc = new MyCalc();
            double actual = calc.y(a, c, x);
            Assert.AreEqual(expected, actual);
        }
    }
}
