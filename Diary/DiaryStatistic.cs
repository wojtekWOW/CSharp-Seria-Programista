using System;
using System.Speech.Synthesis;

namespace StudentDiary

{
    internal class DiaryStatistic
    {
        public float AverageGrade;
        public float MinGrade;
        public float MaxGrade;

        public static void ShowStatistic(DiaryStatistic stats)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Who is the most beautiful girl in the world?    Anna");
            //synth.Speak("Average grade: " + stats.AverageGrade);
            Console.WriteLine("Średnia ocena: " + stats.AverageGrade);
            Console.WriteLine("Najmniejsza ocena: " + stats.MinGrade);
            Console.WriteLine("Najwieksza ocena: " + stats.MaxGrade);
        }
    }
}