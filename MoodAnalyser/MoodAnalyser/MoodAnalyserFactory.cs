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
        public static object CreateMoodAnalyser(string className)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
           Type moodAnalysType = assembly.GetType(className);
           return Activator.CreateInstance(moodAnalysType);
        }
    }
}
