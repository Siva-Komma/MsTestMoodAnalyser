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
<<<<<<< HEAD
        public string AnalyseMood(string message)
=======
        public  string message;
        public ModdAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
>>>>>>> UC2_RefactorMoodAnalyser
        {
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
