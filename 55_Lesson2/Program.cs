using System;

namespace _55_Lesson2
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;
    }
    class Program
    {
        static Student GetStudent()
        {
            var student = new Student();

            student.firstName = "Андрей";
            student.lastName = "Тимохович";
            student.middleName = "Александрович";
            student.age = 29;
            student.id = Guid.NewGuid();
            student.group = "424";

            return student;
        }

        static void Print(Student student)
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"Id: {student.id}");
            Console.WriteLine($"Фамилия: {student.lastName}");
            Console.WriteLine($"Имя: {student.firstName}");
            Console.WriteLine($"Отчество: {student.middleName}");
            Console.WriteLine($"Возраст: {student.age}");
            Console.WriteLine($"Группа: {student.group}");
        }

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();

            Print(firstStudent);
        }
    }
}
