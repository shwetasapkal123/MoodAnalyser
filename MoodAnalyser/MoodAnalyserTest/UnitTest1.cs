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
                ///Arrange 
                MoodAnalyser1 mood = new MoodAnalyser1("I am in Happy Mood");
                string excepted = "happy";
            //Act
                var actual = mood.Mood();
            //Assert
                Assert.AreEqual(excepted, actual);
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
            [TestCategory("Null Exception")]
            public void GivenNullShouldReturnCustomException()
            {
                ///Follow AAA strategy
                ///Arrange 
                string message = null;
                string excepted = "Message cann't be null";
                try
                {
                //Act
                    MoodAnalyser1 mood = new MoodAnalyser1(message);
                    string actual = mood.Mood();
                }
                catch (MoodAnalyzerException ex)
                {
                    Console.WriteLine("Custom Exception :" + ex);
                    Assert.AreEqual(excepted, ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Worst Case Exception :" + ex);
                }
            }
            [TestMethod]
            [TestCategory("Empty Exception")]
            public void GivenEmptyShouldReturnCustomException()
            {
                ///Follow AAA strategy
                ///Arrange
                string message = "";
                string excepted = "Message cann't be Empty";
                try
                {
                    MoodAnalyser1 mood = new MoodAnalyser1(message);
                    string actual = mood.Mood();
                }
                catch (MoodAnalyzerException ex)
                {
                    Console.WriteLine("Custom Exception :" + ex);
                    Assert.AreEqual(excepted, ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Worst Case Exception :" + ex);
                }
            }
        }
    }
    

