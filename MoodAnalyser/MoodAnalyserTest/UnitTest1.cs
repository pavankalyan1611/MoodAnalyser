
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
        //    //string message = "I am in sad Mood";
        //    //MoodAnalyser analyser = new MoodAnalyser(message);
        //    //string expected = "SAD";

        //    ////Act
        //    //string actual = analyser.analyseMood();

        //    ////Assert
        //    //Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void GivenNullMessage_WhenAnalyseShouldReturnMoodAnalysysExceptionHandleMessage()
        {
            //Arrange
            string message =null;
            MoodAnalyser analyser = new MoodAnalyser();
            string expected = "Mood should not be Null";

            //Act
            string actual = analyser.analyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}