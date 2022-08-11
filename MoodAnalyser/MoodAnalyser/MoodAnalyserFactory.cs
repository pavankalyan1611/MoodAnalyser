using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyserPbr
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";//.MoodAnalyser$
            Match result = Regex.Match(className, pattern);
            try
            {
                if (result.Success)
                {
                    try
                    {                       
                        Assembly executing = Assembly.GetExecutingAssembly();
                        Type moodAnalyseType = executing.GetType(className);
                        return Activator.CreateInstance(moodAnalyseType);
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Your input is not valid");
                        throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                    }                  
                }
                else
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
                }
        }
            catch (MoodAnalyserCustomException ex)
            {
               return ex.Message;
            }
            return null;
        }
    }
}
