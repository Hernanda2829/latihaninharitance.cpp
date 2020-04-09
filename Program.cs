using System;

namespace latihaninheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("hernanda", 18);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas", 36, "190302", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("hernanda giri pramudita", 18, "19.11.2761", "hernanda.pramudita@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name = "no name", int age = 0)
        {
            Name = name;
            Age = age;
        }
        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name: {0} and Age: {1}", Name, Age);
        }
    }

    public class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public Teacher(string name ="no name", int age = 0, string teacherId = "no id", string subject = "no subject")
        {
            Name = name;
            Age = age;
            TeacherId = teacherId;
            Subject = subject;
        }
    }

    public class Student : Person
    {
        public string studentId { get; set; }
        public string Email { get; set; }

        public Student(string name = "no name", int age = 0, string student = "no id", string email = "no email")
        {
            Name = name;
            Age = age;
            studentId = studentId;
            Email = email;
        }
    }
}
