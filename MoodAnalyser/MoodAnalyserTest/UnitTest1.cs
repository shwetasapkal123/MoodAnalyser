using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Happy Mood")]
        public void GivenMessageShouldReturnHappy()
        {
            ///Follow AAA strategy
            MoodAnalyser1 mood = new MoodAnalyser1("I am in Happy Mood");
            string excepted = "happy";
            //Act
            var actual = mood.Mood();
            //Assert
            Assert.AreEqual(excepted, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        [TestCategory("SAD Mood")]
        public void GivenMessageShouldReturnSad()
        {
            ///Follow AAA strategy
            ///Arrange 
            MoodAnalyser1 mood = new MoodAnalyser1("I am in SAD Mood");
            string excepted = "sad";
            //Act
            var actual = mood.Mood();
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("Null")]
        public void GivenNullShouldReturnHappy()
        {
            ///Follow AAA strategy
            ///Arrange
            string message = null;
            MoodAnalyser1 mood = new MoodAnalyser1(message);
            string excepted = "happy";
            //Act
            var actual = mood.Mood();
            //Assert
            Assert.AreEqual(excepted, actual);
            Console.WriteLine(actual);
        }
    }
}
    

