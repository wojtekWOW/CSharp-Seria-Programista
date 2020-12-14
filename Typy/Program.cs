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

        private static int IncrementNumber(out int number)
        {
            number = 32;
            return number;
        }
        static void Main(string[] args)
        {
            //PassByValueAndRef();

            //Immutable();

            Arrays();

            
        }

        private static void Arrays()
        {
            float[] ratings;
            ratings = new float[4];
            AddRatings(ratings);

            foreach(var rating in ratings)
                Console.WriteLine(rating);
        }

        private static void AddRatings(float [] ratings)
        {
            if (ratings.Length >= 4)
            {
                ratings[0] = 4.2f;
                ratings[1] = 4.6f;
                ratings[2] = 3.2f;
                ratings[3] = 3.6f;
            }
        }

        private static void Immutable()
        {
            string name = " Marcin ";
            name= name.Trim();
            Console.WriteLine(name);

            
            DateTime date = new DateTime(2015, 2, 3);
            date=date.AddHours(48);
            Console.WriteLine(date);
            date = DateTime.Now;
            Console.WriteLine(date);



            //string name1 = "marcin";
            //bool areEqual = name.Equals(name1, StringComparison.CurrentCulture);
            //Console.WriteLine(areEqual);
        }

        private static void PassByValueAndRef()
        {
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(ref d2);

            Console.WriteLine(d2.nazwaObiektu);

            int x1 = 4;
            IncrementNumber(out x1);

            Console.WriteLine(x1);
        }
    }
}
