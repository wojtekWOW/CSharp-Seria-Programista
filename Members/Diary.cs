using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Members
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        //Parametry=pola
    
        List<float> ratings;
        string imie;

        //Metody
       
        // Computes statitistic (average, max and min grade) for given student
        internal DiaryStatistic ComputeStatistic()
        {
            DiaryStatistic stats = new DiaryStatistic();
            float sum = 0f;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade= ratings.Max();
            stats.MinGrade = ratings.Min();
            return stats;
        }    
              
        /// <summary>
        /// Method adding new rating to diary
        /// </summary>
        /// <param name="rating">new rating</param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }      
       
        /// <summary>
        /// Method to add student's name
        /// </summary>
        /// <returns>imie</returns>
        public string AddName()
        {
            Console.WriteLine("Podaj imie studenta:");
                imie = Console.ReadLine();
            return imie;
        }

        /// <summary>
        /// Method displaying instructions, uses other methods to display answers
        /// </summary>
        /// <param name="student"></param>
        public static void AskForRatings(Diary student)
        {            
            Console.WriteLine($"Podaj oceny ucznia z zakresu 1-10 uzyskane przez  {student.imie}");
            for (; ; )
            {        
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);
        
                if (rating == 11)
                {
                    break;
                }
                if (result == true)
                {
                    if (rating >= 1 && rating <= 10)
                        student.AddRating(rating);
                    else Console.WriteLine("Niepoprawna liczba1 Podaj liczbę z zakresu od 1 do 10");
                }
            }       
        }

    }
}
