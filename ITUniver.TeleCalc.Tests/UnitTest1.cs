using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ITUniver.TeleCalc.ConCalc;

namespace ITUniver.TeleCalc.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            //Arrange
            var calc = new Calc();
            var x = 1;
            var y = 2;

            //Act
            var result1 = calc.Sum(x, y);
            var result2 = calc.Sum(10, 0);
            
            //Asser
            Assert.AreEqual(3, result1);
            Assert.AreEqual(10, result2);
        }

        [TestMethod]
        public void TestMinus()
        {
            //Arrange
            var calc = new Calc();
            var x = 1;
            var y = 2;

            //Act
            var result1 = calc.Minus(x, y);
            var result2 = calc.Minus(10, 0);
            var result3 = calc.Minus(0, 3);
            
            //Asser
            Assert.AreEqual(-1, result1);
            Assert.AreEqual(10, result2);
            Assert.AreEqual(-3, result3);
        }

        [TestMethod]
        public void TestUmn()
        {
            //Arrange
            var calc = new Calc();
            var x = 1;
            var y = 2;

            //Act
            var result1 = calc.Umn(x, y);
            var result2 = calc.Umn(10, 0);
            
            //Asser
            Assert.AreEqual(2, result1);
            Assert.AreEqual(0, result2);
        }

        [TestMethod]
        public void TestDel()
        { 
            //Arrange
            var calc = new Calc();
            var x = 1;
            var y = 2;

            //Act
            var result1 = calc.Del(x, y);
            var result2 = calc.Del(10, 0);
            var result3 = calc.Del(0, 10);
            
            //Asser
            Assert.AreEqual(0.5, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(0, result3);
        }

        [TestMethod]
        public void TestStep()
        {
            //Arrange
            var calc = new Calc();
            var x = 3;
            var y = 2;

            //Act
            var result1 = calc.Step(x, y);
            var result2 = calc.Step(10, 0);

            //Asser
            Assert.AreEqual(9, result1);
            Assert.AreEqual(1, result2);
        }
    }
}
