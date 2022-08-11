using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserPbr
{
    public class MoodAnalyse
    {
        public string message;
        public MoodAnalyse(string message)
        {
            this.message = message;
        }

        public string analyseMood()
        {
            try
            {   //"null"==""
                if (message == null)
                    
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");  
                
                else if (this.message.Equals(string.Empty))  // ""==null
                                                              
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");                
                
                else if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (MoodAnalyserCustomException obj)
            {
               string exception = obj.Message;
                return exception;
            }           

            //finally
            //{
            //    Console.WriteLine("This code will always execute irrespective of exception came or not!!!!");
            //}
        }       
    }
}
