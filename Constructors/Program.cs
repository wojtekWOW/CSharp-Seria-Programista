using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person(1, "Tomek");
            Person person2 = new Person(2, "Tomek", "Nowak");
            Person person3 = new Person(2, "Tomek", "Nowak", "Katowice", 22, "man");
        }
    }
}
