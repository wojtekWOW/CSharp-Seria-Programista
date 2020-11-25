using System;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddName();
            diary.AddRating(3);
            diary.AddRating(5);

            Diary diary1 = diary;
            diary1.AddRating(8);

            Diary diary3 = diary1;
            diary3.AddRating(4);
        }
    }
}
