using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKata;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Tests
{
    [TestClass()]
    public class StringCalculatorTests
    {
        StringCalculator stringCalculator = new StringCalculator();
        [TestMethod()]
        public void addTestEmptyString()
        {            
            string emptyString = "";
            int result = stringCalculator.add(emptyString);
            Assert.AreEqual(0, result);
        }
        [TestMethod()]
        public void addTestSingleValue()
        {
            string string123 = "123";
            int result = stringCalculator.add(string123);
            Assert.AreEqual(123, result);
        }
        [TestMethod()]
        public void addTestAddingTwoNumbers()
        {
            string stringTest = "123,456";
            int result = stringCalculator.add(stringTest);
            Assert.AreEqual(579, result);
        }
        [TestMethod()]
        public void addTestAddingTwoNumbersNewLineSeparator()
        {
            string stringTest = "123\n456";
            int result = stringCalculator.add(stringTest);
            Assert.AreEqual(579, result);
        }
        [TestMethod()]
        public void addTestAddingThreeNumbers()
        {
            string stringTest = "123\n456,21";
            int result = stringCalculator.add(stringTest);
            Assert.AreEqual(600, result);
        }
        [TestMethod(),ExpectedException(typeof(ArgumentException))]
        public void addTestNegativeNumberException()
        {
            string stringTest = "123\n-456,21";
            int result = stringCalculator.add(stringTest);
        }
        [TestMethod()]
        public void addTestAddingNumberGraterThan1000()
        {
            string stringTest = "123\n456,21,1200";
            int result = stringCalculator.add(stringTest);
            Assert.AreEqual(600, result);
        }
        [TestMethod()]
        public void addTestCustomSeparator()
        {
            string stringTest = "//a123\n456,21,1200a20";
            int result = stringCalculator.add(stringTest);
            Assert.AreEqual(620, result);
        }

    }
}