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
            Console.WriteLine(actual);
        }
        [TestMethod]
        [TestCategory("Null Exception")]
        public void GivenNullShouldReturnCustomException()
        {
            ///Follow AAA strategy
            ///Arrange , Act and in last Assert
            string message = null;
            string excepted = "Message cann't be null";
            try
            {
                MoodAnalyser1 mood = new MoodAnalyser1(message);
                string actual = mood.Mood();
            }
            catch (MoodAnalyzerException ex)
            {
                Console.WriteLine("Custom Exception :" + ex.Message);
                Assert.AreEqual(excepted, ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Worst Case Exception :" + ex.Message);
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
                //Act
                MoodAnalyser1 mood = new MoodAnalyser1(message);
                string actual = mood.Mood();
            }
            catch (MoodAnalyzerException ex)
            {
                //Assert
                Console.WriteLine("Custom Exception :" + ex.Message);
                Assert.AreEqual(excepted, ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Worst Case Exception :" + ex.Message);
            }
        }
        /// <summary>
        /// TC-4.1 Returns the mood analyser object
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserReflection_ShouldReturnObject()
        {
            object expected = new MoodAnalyser1();
            object actual = FactoryMoodAnalyser.CreateMoodAnalyse("MoodAnalyser.MoodAnalyser1", "MoodAnalyser1");
            expected.Equals(actual);
        }
        /// <summary>
        /// TC-4.2 should throw NO_SUCH_CLASS exception.
        /// </summary>
        [TestMethod]
        public void GivenClassNameImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "Class not found No such class";
            try
            {
                object actual = FactoryMoodAnalyser.CreateMoodAnalyse("MoodAnalyser.MoodAnalyser1", "MoodAnalyser1");
                Console.WriteLine(actual);
            }
            catch (MoodAnalyzerException excpt)
            {
                Assert.AreEqual(expected, excpt.Message);
            }
        }
        /// <summary>
        /// TC-4.3 should throw NO_SUCH_CONTRUCTOR exception.
        /// </summary>
        [TestMethod]
        public void GivenConstructorNameImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = FactoryMoodAnalyser.CreateMoodAnalyse("MoodAnalyser.MoodAnalyser1", "MoodAnalyzer");
                Console.WriteLine(actual);
            }
            catch (MoodAnalyzerException excpt)
            {
                Assert.AreEqual(expected, excpt.Message);
            }
        }
    }
}
    
    

