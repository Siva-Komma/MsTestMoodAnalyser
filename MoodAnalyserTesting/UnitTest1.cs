using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyserTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("ExceptionTestCase")]
        [DataRow("I am in Happy Mood", "Happy")]
        [DataRow("I am in Sad Mood", "Sad")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        public void MessageShouldReturn_TypeofMood(string message,string expected)
        {
            try
            {
                ModdAnalyzer moodAnalyser = new ModdAnalyzer(message);
                string result = moodAnalyser.AnalyseMood();
                if (result != null)
                {
                    Assert.AreEqual(result, expected);
                }
                Console.WriteLine(result);
            }catch(Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void CustomException()
        {
            string expected = "Message should not be null";
            try
            {
                string message = null;
                ModdAnalyzer moodAnalyser = new ModdAnalyzer(message);
                string actual = moodAnalyser.AnalyseMood();
            }catch(InvalidCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
