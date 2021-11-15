using System;
using System.Collections.Generic;
using System.IO;

namespace CSVDemo
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Load();
            while(true)
            {
                Console.WriteLine("1. Add Student\n2. Save to file\n3. Load from file\n4. List all students\n5. Remove Student\n6. Exit");
                Console.Write("Select one of the options: ");

                switch(Console.ReadLine())
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        Save();
                        break;
                    case "3":
                        Load();
                        break;
                    case "4":
                        ListAllStudent();
                        break;
                    case "5":
                        RemoveStudent();
                        break;
                    case "6":
                        Console.WriteLine("BYE");
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine();
            }

           
        }

        private static void RemoveStudent()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i +1}. {students[i].Name}");
            }
            Console.Write("Select a student to remove from: ");

            int position = int.Parse(Console.ReadLine()) -1;
            students.RemoveAt(position);
        }

        private static void ListAllStudent()
        {
           foreach(Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void AddStudent()
        {
            while (true)
            {
                Console.Write("Enter your name or type 'quit' to quit the program: ");
                string name = Console.ReadLine();

                if (name.ToLower() == "quit")
                    break;

                Console.Write("Enter your id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                students.Add(new Student(id, name, age));
            }
        }

        private static void Load()
        {
            using (StreamReader reader = new StreamReader("students.csv"))
            {
                string[] data;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine($"CSV line -- {line}");
                    data = line.Split(",");
                    students.Add(new Student(int.Parse(data[0]), data[1], int.Parse(data[2])));
                    Console.WriteLine("Data after splitting...");
                    
                    foreach (string eachData in data)
                    {
                        Console.WriteLine(eachData);
                    }
                }
            }
        }

        private static void Save()
        {
            bool append = false;

            if (File.Exists("students.csv"))
            {
                Console.Write("Seems this file exists, do you want to overwrite? (y/n): ");
                append = Console.ReadLine().ToLower()[0] != 'y';
            }  

            using (StreamWriter writer = new StreamWriter("students.csv", append))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine($"{student.ToCSV()}");
                }
            }
          
        }
    }
}
