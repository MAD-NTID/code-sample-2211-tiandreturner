using System;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[2];
            //int[] numbers = new int[7];
            //numbers[0] = 10;
            //numbers[1] = 12;
            //numbers[2] = 67;
            //numbers[3] = 18;
            //numbers[4] = 31;
            //numbers[5] = 24;
            //numbers[6] = 11;

            //string[] names = {"Leeon", "Decker",
            //    "Juan", "Austyn",
            //    "Joseph", "Shahria", "Professor Turner"
            //};

            Person person = new Person();
            person.name = "Professor Turner";
            person.favoriteNumber = 11;

            people[0] = person;
            Person person1 = new Person();
            person1.name = "Decker";
            person1.favoriteNumber = 12;

            people[1] = person1;

            Array.Sort(people);
            for (int index = 0; index < people.Length; index++)
            {
                Console.WriteLine($"{people[index].name}'s favorite number is {people[index].favoriteNumber}");
            }
        }
    }
}
