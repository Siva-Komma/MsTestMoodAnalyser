using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class ModdAnalyzer
    {
        public  string message;
        public ModdAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }catch(NullReferenceException ex)
            {
               // Console.WriteLine(ex.Message);
               // return default;
                throw new InvalidCustomException("Message should not be null",InvalidCustomException.ExceptionTypes.NULL_MESSAGE);
            }
        }
    }
}
