using System;
namespace constructorseg{
    internal class Program{
        public class Teacher{
            public Teacher(){
                Console.WriteLine("Default Constructor Invoked!");
                Console.WriteLine("------------------------------------");
            }
        }
        public class Student{
            public string name;
            static Student(){
                Console.WriteLine("Static Constructor Invoked!");
                Console.WriteLine("------------------------------------");
            }
            public Student(string n){
                Console.WriteLine("Parameterized Constructor Invoked!");
                Console.WriteLine($"{n} ia  a student");
                Console.WriteLine("------------------------------------");
            }
            public Student(Student a){
                Console.WriteLine("Copy Constructor Invoked!");
                Console.WriteLine($"{a.name}");
            }
        }
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            Student s1 = new Student("student 1" );
            Student s2 = new Student("student 2");
            Student a1 = new Student(s1);
            Console.ReadKey();

        }
    }
}
