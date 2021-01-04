using System;
using System.Speech.Synthesis;

namespace Members

{
    internal class DiaryStatistic
    {
        public float AverageGrade;
        public float MinGrade;
        public float MaxGrade;

        public static void ShowStatistic(DiaryStatistic stats)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Who is the most beautiful girl in the world?    Anna");
            
            WriteResult("Średnia ocena: " , stats.AverageGrade, 5, 6, 8, 4, 5, 6, 3);
            WriteResult("Najmniejsza ocena: " , (int)stats.MinGrade);
            WriteResult("Najwieksza ocena: " , (long)stats.MaxGrade);
            WriteResult("Najwieksza ocena: ", (long)stats.MaxGrade, 1);
        }
        static void WriteResult(string description, params float[] result)
        {
            Console.WriteLine(description + " " + result[0] + " " + result[1] + " " + result[5]);
        }
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + " " + result);
        }
        static void WriteResult(string description,  long result)
        {
            Console.WriteLine(description + " " + result);
        }
        static void WriteResult(string description, long result, long test)
        {
            Console.WriteLine(description + " " + result + " " + test);
        }
    }
}