using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StudentDiary
{
    class Program
    {      
        
        static void Main(string[] args)
        {   
            Diary student1 = new Diary();
            student1.AddName();
            Diary.AskForRatings(student1);
            DiaryStatistic stats = student1.ComputeStatistic();
            DiaryStatistic.ShowStatistic(stats);

            Diary student2 = new Diary();
            student2.AddName();
            Diary.AskForRatings(student2);
            stats = student2.ComputeStatistic();
            DiaryStatistic.ShowStatistic(stats);

            
        }
        
    }
}
