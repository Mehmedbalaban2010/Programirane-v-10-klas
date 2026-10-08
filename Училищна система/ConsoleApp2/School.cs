using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class School
    {
        public Teacher Teacher { get; set; }

        public Student Student { get; set; }

        public Subject Subject { get; set; }

        public School(string nameSchool, string city, Teacher teacher, Student student, Subject subject)
        {
            Console.WriteLine($"Име на училището: {nameSchool}");

            Console.WriteLine($"Град: {city}");

            Console.WriteLine($"Име на учителя: {teacher.Name}");

            Console.WriteLine($"Име на ученика: {student.Name}");

            Console.WriteLine($"Възраст на ученика: {student.Age}");

            Console.WriteLine($"Клас: {student.Grade}");

            Console.WriteLine($"Име на предмета: {subject.FavoriteSubject}");
        }
    }
}
