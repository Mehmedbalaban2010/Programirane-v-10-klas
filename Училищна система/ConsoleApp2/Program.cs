using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Student student = new Student("Иван Петров", 15, 9);

            Subject subject = new Subject("Програмиране", 4);

            Teacher teacher = new Teacher("Мария Иванова", "Програмиране");

            School school = new School("СУ „Св. Паисий Хилендарски“", "Пловдив", teacher, student, subject);
        }
    }
}
