using System;
using CodeTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class SumOfThreeAndFiveTests
    {
        [TestMethod]
        public void Soluution_RetunsSummedValues_Regardless()
        {
            //Arrange
            var obj = new SumOfThreeAndFive();
            //Act

            int expected = 23;
            int actual = obj.Solution(10);

            //Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
