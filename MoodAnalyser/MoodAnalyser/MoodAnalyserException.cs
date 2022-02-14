using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    //Inheriting base Exception Class.
    //Inheriting base Exception Class.
    public class MoodAnalyserException : Exception
    {
        public ExceptionType type;
        //Enumeration
        public enum ExceptionType
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION,
            NO_SUCH_CLASS,
            NO_SUCH_CONSTRUCTOR,
            NO_SUCH_METHOD
        }
        //Exception Constructor.
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

