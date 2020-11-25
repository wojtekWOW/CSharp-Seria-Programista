using System;

namespace Hello
{
    class Program
    {       
        static void Main(string[] args)
        {
            for (; ;)
            {
                WelcomeUser();
                CheckAgeForDrinking();
                ResetConsole();
            }

        }
        /// <summary>
        /// Asks for name and welcomes
        /// </summary>
        private static void WelcomeUser()
        {
            Console.Write("Wpsiz swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Witaj {name}!");
        }
        /// <summary>
        /// Asks for age and checks if adult
        /// </summary>
        private static void CheckAgeForDrinking()
        {
            Console.Write("Wpisz ile masz lat:");
            int age = 0;
            bool adult = int.TryParse(Console.ReadLine(), out age);
            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jesteś pełnoletni możesz wypić browara!");
            }
            else if (adult == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wprowadziłeś niepoprawne dane");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Możemy Ci zaproponować mleko");
            }
        }
        /// <summary>
        /// Resets console display
        /// </summary>
        private static void ResetConsole()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
    }
}
