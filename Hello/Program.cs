using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ;)
            {
                Console.Write("Wpsiz swoje imię: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Witaj {name}!");
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
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
            
            }

        }
    }
}
