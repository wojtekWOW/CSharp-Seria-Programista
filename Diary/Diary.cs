﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDiary
{
    class Diary
    {
        //Parametry=pola
    
        List<float> ratings = new List<float>();

        //Metody
        
        /// <summary>
        /// Method adding new rating to diary
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        /// <summary>
        /// Method calculating average rating
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {
            float sum = 0, average = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            average = sum / ratings.Count();
            return average;
        }

        /// <summary>
        /// Method returning highest rating
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        /// <summary>
        /// Method returning lowest rating
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return ratings.Min();
        }

        public static void AskForRatingsAndShowStatistic(Diary student)
        {
            for (; ; )
            {
                Console.WriteLine("Podaj odene z zakresu 1-10");
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

            Console.WriteLine("Średnia ocen to :" + student.CalculateAverage());
            Console.WriteLine("Najwieksza ocena to :" + student.GiveMaxRating());
            Console.WriteLine("Najniższa ocena to :" + student.GiveMinRating());
            Console.ReadKey();
        }
    }
}