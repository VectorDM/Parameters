using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = null;
            bool b = StudentFactory.Create("Tim", 23, out stu);
            if (b == true)
            {
                Console.WriteLine("Student {0}, age is {1}.",stu.Name,stu.Age);
            }
        }
    }

    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class StudentFactory
    {
        public static bool Create(string StuName, int StuAge, out Student result)
        {
            result = null;
            if (string.IsNullOrEmpty(StuName))
            {
                return false;
            }

            if (StuAge<20 || StuAge>80)
            {
                return false;
            }

            result = new Student() {Age = StuAge,Name = StuName};
            return true;
        }
    }

}
