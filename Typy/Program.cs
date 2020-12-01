using System;

namespace StudentDiary
{
    class Program
    {
        private static void GiveName(ref Diary diary)
        {
            diary = new Diary();
            diary.nazwaObiektu="Nowy dzienniczek Wojtka";
        }

        private static int IncrementNumber(int number)
        {
            number = 32;
            return number;
        }
        static void Main(string[] args)
        {            
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(ref d2);
                        
            Console.WriteLine(d2.nazwaObiektu);
            
            int x1 = 4;
            x1 = IncrementNumber(x1);
            Console.WriteLine(x1);

            DateTime d;
            string name = "Marcin";
            string name1 = "marcin";
            bool areEqual = name.Equals(name1, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(areEqual);
        }       
    }
}
