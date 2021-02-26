using CodeTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class SumOfDigitsDigitalRootTests
    {
        [TestMethod]
        public void BreakNumberApart_ReturnsIntegerArray_Regardless()
        {
            //Arrange
            var obj = new SumOfDigitsDigitalRoot();

            //Act

            int expected = 5;
            int[] actual = obj.BreakNumberApart(12345);

            //Assert

            Assert.AreEqual(expected, actual.Length);
        }

        [TestMethod]
        public void DigitalRoot_FindsSingleDigitFromSum_Regardless()
        {
            //Arrange
            var obj = new SumOfDigitsDigitalRoot();

            //Act
            int actual1 = obj.DigitalRoot(16);
            //int actual2 = obj.DigitalRoot(456);

            int expected1 = 7;
            //int expected2 = 6;
            //Assert

            Assert.AreEqual(expected1, actual1);
            //AreEqual(expected2, actual2);
        }
    }
}
