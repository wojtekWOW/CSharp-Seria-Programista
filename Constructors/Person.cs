using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Person
    {
        int id;
        string firstName;
        string lastName;
        string adress;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            firstName = "Marcin";
            lastName = "Kowalski";
            age = 14;
        }
        public Person(int id, string firstName, string lastName, string adress, int age, string gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.adress = adress;
            this.gender = gender;
        }
        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            adress = "Katowice";
            age = 18;
        }
        public Person(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }
    }
}
