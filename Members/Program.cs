using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary student1 = new Diary();

            student1.NameChanged += new NameChangeDelegate(OnNameChanged);
            student1.NameChanged += new NameChangeDelegate(OnNameChanged2);
            //student1.AddName();
            //Diary.AskForRatings(student1);
            //DiaryStatistic stats = student1.ComputeStatistic();
            //DiaryStatistic.ShowStatistic(stats);

            student1.Name="Dzienniczek Wojtka";
            student1.Name = null;
            student1.Name = "Dzienniczek Ani";
            Console.WriteLine(student1.Name);
            
            #region strudent2
            //Diary student2 = new Diary();
            //student2.AddName();
            //Diary.AskForRatings(student2);
            //stats = student2.ComputeStatistic();
            //DiaryStatistic.ShowStatistic(stats);
            #endregion

            Console.ReadKey();
        }

        private static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Zmiana nazwy z {existingName} na {newName}");
        }
        private static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("**********************");
        }
    }
}
