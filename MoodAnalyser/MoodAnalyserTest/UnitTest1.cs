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
                ///Arrange , Act and in last Assert
                MoodAnalyser1 mood = new MoodAnalyser1();
                string message = "I am in Happy Mood";
                string excepted = "happy";
                var actual = mood.Mood(message);
                Assert.AreEqual(excepted, actual);
            Console.WriteLine(actual);
            }
            [TestMethod]
            [TestCategory("SAD Mood")]
            public void GivenMessageShouldReturnSad()
            {
                ///Follow AAA strategy
                ///Arrange , Act and in last Assert
                MoodAnalyser1 mood = new MoodAnalyser1();
                string message = "I am in SAD Mood";
                string excepted = "sad";
                var actual = mood.Mood(message);
                Assert.AreEqual(excepted, actual);
            Console.WriteLine(actual);
            }
        }
    }
    

