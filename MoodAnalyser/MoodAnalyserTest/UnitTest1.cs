
using MoodAnalyserPbr;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {

        //[TestMethod]
        //public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        //{
        //    //Arrange
        //    //string message ="";
        //    string expected = "Constructor is not found";
        //    //Act
        //    string actual = (string) MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserPbr.MoodAnalyser", "MoodAnalyse");
        //    //Assert
        //       //expected.Equals(obj);
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = "Class not found"; //2000
           //MoodAnalyser obj = (MoodAnalyser)expected;           
            object Actual = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserPbr.MoodAnalyse", "MoodAnalyse", "HAPPY");
            //expected.Equals(Actual);
            Assert.AreEqual(expected, Actual);
        }
    }
}