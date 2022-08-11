
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
        public void GivenEmptyOrNullMessage_WhenAnalyseShouldReturnExceptionHandleMessage()
        {
            //Arrange
            string message ="";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string expected = "Mood should not be empty";

            //Act
            string actual = analyser.analyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}