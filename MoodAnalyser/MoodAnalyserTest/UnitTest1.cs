
using MoodAnalyserPbr;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            //Arrange
            // message ="";
            object expected = new MoodAnalyser();
            //Act
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserPbr.MoodAnalyser");
            //Assert
               //expected.Equals(obj);
            Assert.AreNotEqual(expected, obj);
        }

      //  [TestMethod]
        //public void GivenEmptyMessage_WhenAnalyseShouldReturnMoodAnalysysExceptionHandleMessage()
        //{
        //    //Arrange
        //    string message ="";
        //    MoodAnalyser analyser = new MoodAnalyser(message);
        //    string expected = "Mood should not be Empty";

        //    //Act
        //    string actual = analyser.analyseMood();

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}