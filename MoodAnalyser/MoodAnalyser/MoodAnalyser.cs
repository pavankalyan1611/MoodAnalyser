using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserPbr
{
    public class MoodAnalyser
    {
        public string message = null;      
       
        public string analyseMood()
        {
            try
            {   //"null"==""
                if (message == null)
                {
                    throw new NullReferenceException();
                }
                if (this.message.Equals(string.Empty))  // ""==null
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException obj)
            {
                return ("HAPPY");
            }           
            finally
            {
                Console.WriteLine("This code will always execute irrespective of exception came or not!!!!");
            }           
        }       
    }
}
