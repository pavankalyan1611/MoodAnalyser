
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
            object expected = new MoodAnalyser("HAPPY"); //2000
           //MoodAnalyser obj = (MoodAnalyser)expected;           
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserPbr.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(obj);
            //Assert.AreEqual(expected, obj);
        }
    }
}