using System;

namespace _60_Lesson2
{

    class Student
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;

        public Student(string lastName, DateTime birthday)
        {
            _lastName = lastName;
            _birthday = birthday;
        }

        public Student(string lastName, string firstName, string middleName, DateTime birthday)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _birthday = birthday;
        }

        public Student(Student student)
        {
            _firstName = student._firstName;
            _middleName = student._middleName;
            _lastName = student._lastName;
            _birthday = student._birthday;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

    public void Print()
        {
            Console.WriteLine($"Имя: {_lastName}\nФамилия: {_firstName}\nОтчество: {_middleName}\nДата рождения: {_birthday.ToString("d")}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Тимохович", "Андрей", "Александрович", new DateTime(1992, 02, 04));
            Student student2 = new Student(student1);

            student1.SetLastName("#############");

            student1.Print();
            student2.Print();
        }
    }
}
