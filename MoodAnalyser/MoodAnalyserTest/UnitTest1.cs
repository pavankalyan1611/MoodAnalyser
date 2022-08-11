
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
        public void GivenEmptyMessage_WhenAnalyseShouldReturnMoodAnalysysExceptionHandleMessage()
        {
            //Arrange
            string message ="";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string expected = "Mood should not be Empty";

            //Act
            string actual = analyser.analyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}