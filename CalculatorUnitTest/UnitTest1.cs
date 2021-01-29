using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        MyCalculator.Classes.CalculatorLogic calculator = new MyCalculator.Classes.CalculatorLogic();

        [TestMethod]
        public void TestAddition()
        { 
            Assert.AreEqual(calculator.Add(1, 1), 2); 
        }

        [TestMethod]
        public void TestSubtraction()
        {  
            Assert.AreEqual(calculator.Subtract(2, 1), 1); 
        }

        [TestMethod]
        public void TestMultiplication()
        { 
            Assert.AreEqual(calculator.Multiply(2, 2), 4); 
        }

        [TestMethod]
        public void TestDivision()
        { 
            Assert.AreEqual(calculator.Divide(4, 4), 1);
        } 
    }
}
