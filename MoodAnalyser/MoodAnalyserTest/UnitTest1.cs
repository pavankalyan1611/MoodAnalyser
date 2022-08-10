
using MoodAnalyserPbr;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {       

        [TestMethod]
        public void GivenSadMoodMessage_WhenAnalyseShouldReturnSad()
        {
            //Arrange
            MoodAnalyser analyser = new MoodAnalyser();
            string message = "I am in Sad Mood";
            string expected = "SAD";

            //Act
            string actual = analyser.analyseMood(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}