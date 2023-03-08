using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyserTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMood_WhenAnalysed_ShouldReturnSad()
        {
            ModdAnalyzer moodAnalyser = new ModdAnalyzer("I am in Sad Mood");
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "Sad");
            Console.WriteLine(result);
        }
        [TestMethod]
        public void GivenSadMood_WhenAnalysed_ShouldReturnHappy()
        {
            ModdAnalyzer moodAnalyser = new ModdAnalyzer("I am in Happy Mood");
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "Happy");
            Console.WriteLine(result);
        }
    }
}
