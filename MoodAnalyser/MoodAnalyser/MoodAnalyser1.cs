using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyser1
    {
        //variable
        public string message;
        /// <summary>
        /// default contructor
        /// </summary>
        public MoodAnalyser1()
        {

        }
        //parameterized constructor
        public MoodAnalyser1(string message)
        {
            this.message = message;
        }
        //Method to return the type of Mood
        public string Mood()
        {
            try
            {
                message = message.ToLower();
                if (message == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_EXCEPTION, "Message cann't be null");
                }
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_EXCEPTION, "Message cann't be Empty");
                }
                if (message.Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
        }
    }
}

