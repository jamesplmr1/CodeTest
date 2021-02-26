using System;
using System.Linq;
using CodeTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class LongestSentenceTests
    {
        [TestMethod]
        public void BreakStringIntoSentences_ReturnListOfSentences_Regardless()
        {
            //Arrange
            string testString = "We Test Coders. Give us a try?";
            var solution = new LongestSentence();

            //Act
            solution.BreakStringIntoSentences(testString);
            int actual = solution.sentences.Length;
            int expected = 3; 

            // Assert
            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void FindLongestSentence_ReturnsListsOfWords_Regardless()
        {
            //Arrange
            var solution = new LongestSentence();
            string testString = "We Test Coders. Give us a try? Please give us a try, I promise we will be nice. No! Ok then.";

            solution.BreakStringIntoSentences(testString);

            //Act
            int actual = 11;
            int expected = solution.FindLongestSentence();

            // Assert
            Assert.AreEqual(actual, expected);

        }
    }
}
