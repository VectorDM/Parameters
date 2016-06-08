using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            int y = 100;
            stu.AddOne(y);//传值参数
            Console.WriteLine(y);//100
        }
    }

    class Student
    {
        public void AddOne(int x)//值参数
        {
            x = x + 1;
            Console.WriteLine(x);//101
        }
    }
}
