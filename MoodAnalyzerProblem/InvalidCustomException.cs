using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class InvalidCustomException : Exception
    {
        public ExceptionTypes exceptionTypes;
        public enum ExceptionTypes
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE
        }
        public InvalidCustomException(string message,ExceptionTypes exceptionTypes) :base(message)
        {
            this.exceptionTypes = exceptionTypes;
            Console.WriteLine(message);
        }
    }
}
