
using MoodAnalyserPbr;

Console.WriteLine("Enter User Mood: ");
string message = Console.ReadLine();
MoodAnalyser mood = new MoodAnalyser(message);
Console.WriteLine(mood.analyseMood());;


