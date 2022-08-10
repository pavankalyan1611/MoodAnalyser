
using MoodAnalyserPbr;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {

        //[TestMethod]
        //public void GivenSadMoodMessage_WhenAnalyseShouldReturnSad()
        //{
        //    //Arrange
        //    string message = "I am in Sad Mood";
        //    MoodAnalyser analyser = new MoodAnalyser(message);
        //    string expected = "SAD";

        //    //Act
        //    string actual = analyser.analyseMood();

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void GivenEmptyMessage_WhenAnalyseShouldReturnExceptionMessage()
        {
            //Arrange
            string message =null;
            MoodAnalyser analyser = new MoodAnalyser();
            string expected = "HAPPY";

            //Act
            string actual = analyser.analyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}