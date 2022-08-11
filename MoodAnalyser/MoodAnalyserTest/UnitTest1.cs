
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
            string expected = "Constructor is not found";
            //Act
            string actual = (string) MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserPbr.MoodAnalyser", "MoodAnalyse");
            //Assert
               //expected.Equals(obj);
            Assert.AreEqual(expected, actual);
        }    
    }
}