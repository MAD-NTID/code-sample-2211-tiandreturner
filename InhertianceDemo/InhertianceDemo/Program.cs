using System;
using System.Collections.Generic;

namespace InhertianceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Student> students = new List<Student>();
            Person aPerson = new Person()
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = DateTime.Now,
                ID = 000000000000000000
            };
            //Console.WriteLine(aPerson);
            people.Add(aPerson);

            Student aStudent = new Student()
            {
                FirstName = "Jane",
                LastName = "Doe",
                DateOfBirth = DateTime.Now,
                ID = 1,
                Credits = 12,
                ProgramCode = "MAD",
                ProgramYear = 1
            };
            people.Add(aStudent);
            students.Add(aStudent);
            //Console.WriteLine(aStudent);

            Faculty aFaculty = new Faculty()
            {
                FirstName = "Tiandre",
                LastName = "Turner",
                DateOfBirth = DateTime.Now,
                ID = 3,
                Rank = "Lecturer",
                Degree = "BS in IT"
            };
            people.Add(aFaculty);
 
            //Console.WriteLine(aFaculty);

            foreach (Person person in people)
            {
                if (person is Faculty)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}
