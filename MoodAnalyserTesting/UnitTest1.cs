using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyserTesting
{
    [TestClass]
    public class UnitTest1
    {
        ModdAnalyzer moodAnalyser = new ModdAnalyzer();
        [TestMethod]
        public void GivenSadMood_WhenAnalysed_ShouldReturnSad()
        {
            string result = moodAnalyser.AnalyseMood("I am in Sad Mood");
            if (result != null)
            {
                Assert.AreEqual(result, "Sad");
            }
            Console.WriteLine(result);
        }
        [TestMethod]
        public void GivenSadMood_WhenAnalysed_ShouldReturnHappy()
        {
            string result = moodAnalyser.AnalyseMood("I am in Happy Mood");
            Assert.AreEqual(result, "Happy");
            Console.WriteLine(result);
        }
    }
}
