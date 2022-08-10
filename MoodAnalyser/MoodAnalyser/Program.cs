
using MoodAnalyserPbr;


MoodAnalyser mood = new MoodAnalyser();
Console.WriteLine("Enter User Mood: ");
string message = Console.ReadLine();
Console.WriteLine(mood.analyseMood(message));


