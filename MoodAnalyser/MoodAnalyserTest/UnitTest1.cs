
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
            //string message ="";
            string expected = "Class not found";
            //Act
            string actual = (string) MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserPbr.MoodAnalyser", "MoodAnalyser");
            //Assert
               //expected.Equals(obj);
            Assert.AreEqual(expected, actual);
        }    
    }
}