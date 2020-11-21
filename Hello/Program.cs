using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpsiz swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Witaj {name}!");
            Console.Write("Wpisz ile masz lat:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Jesteś pełnoletni możesz wypić browara!");
            }
            else
            {
                Console.WriteLine("Możemy Ci zaproponować mleko");
            }

        }
    }
}
