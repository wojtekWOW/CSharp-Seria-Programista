using System;
namespace StudentDiary
{
    internal class DiaryStatistic
    {
        public float AverageGrade;
        public float MinGrade;
        public float MaxGrade;

        public static void ShowStatistic(DiaryStatistic stats)
        {
            Console.WriteLine("Średnia ocena: " + stats.AverageGrade);
            Console.WriteLine("Najmniejsza ocena: " + stats.MinGrade);
            Console.WriteLine("Najwieksza ocena: " + stats.MaxGrade);
        }
    }
}