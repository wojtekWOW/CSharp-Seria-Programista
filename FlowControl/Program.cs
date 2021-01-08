using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;

        static void Main(string[] args)
        {
            //InstructionsIf();


            Console.WriteLine("Podaj imie");
           name =  Console.ReadLine();
            switch (name)
            {
                case "Marcin":
                    Method1();
                    break;
                case "Tomek":
                    Method2();
                    Method3();
                    break;

                default:
                    Method4();
                    break;
            }
            Console.ReadKey();
        }

        private static void InstructionsIf()
        {
            Console.WriteLine("Podaj swój wiek");
            age = int.Parse(Console.ReadLine());

            string test = age > 18 ? "Pełnoletni" : "Dziecko";

            Console.WriteLine(test);

            Console.WriteLine("Podaj swoje imie");
            Console.ReadLine();

            if (age <= 10)
            {
                if (name == "Marcin")
                {

                }
                Method1();
            }
            else if (age < 20)
            {
                Method2();
            }
            else if (age <= 30)
            {
                Method3();
            }
            else
            {
                Method4();
            }
        }

        private static void Method4()
        {
            Console.WriteLine($"Jestes w metodzie 4");
        }

        private static void Method3()
        {
            Console.WriteLine($"Jestes w metodzie 3");
        }

        private static void Method2()
        {
            Console.WriteLine($"Jestes w metodzie 2");
        }

        private static void Method1()
        {
            Console.WriteLine("Jestes w metodzie 1"); ;
        }
    }
}
