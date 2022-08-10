using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserPbr
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string analyseMood()
        {
            if (this.message.ToUpper().Contains("SAD"))
                return "SAD";
            else
                return "HAPPY";
        }       
    }
}
