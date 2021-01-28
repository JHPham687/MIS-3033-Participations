using System;
using System.Collections.Generic;
using System.IO;

namespace Student
{
    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("studentdataRandom100Rows.csv");

            //Student s = new Student(5, "Joe", "Joe", "Blue");
            //Student s2 = new Student();
            //s2.FirstName = "Joe";
            //s2.LastName = "Joe"; 

            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                var pieces = line.Split(',');
                Int64 id = Convert.ToInt64(pieces[0]);

                Student currentStudent = new Student(Convert.ToInt64(pieces[0], pieces[1], pieces[2], pieces[3]);


            }

            Console.ReadKey();
        }
    }
}
