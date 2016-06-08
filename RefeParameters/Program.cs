using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefeParameters
{
    //class Program
    //{
    //    //引用类型的传值参数
    //    static void Main(string[] args)
    //    {
    //        Student stu = new Student() { Name = "Tim" };
    //        SomeMethod(stu);
    //        Console.WriteLine("{0},{1}", stu.GetHashCode(), stu.Name);

    //    }

    //    static void SomeMethod(Student stu)
    //    {
    //        stu = new Student() { Name = "Tim" };
    //        Console.WriteLine("{0},{1}", stu.GetHashCode(), stu.Name);
    //    }
    //}

    //class Student
    //{
    //    public string Name { get; set; }
    //}

    class Program
    {
        static void Main()
        {
            Student outerStu = new Student() {Name = "Tim"};
            Console.WriteLine("HashCode={0},Name={1}",outerStu.GetHashCode(),outerStu.Name);
            Console.WriteLine("======================================");
            IWantSideEffect(ref outerStu);
            Console.WriteLine("HashCode={0},Name={1}", outerStu.GetHashCode(), outerStu.Name);
        }

        static void IWantSideEffect(ref Student stu)
        {
            //stu = new Student() {Name = "Tom"};
            stu.Name = "Tom";
            Console.WriteLine("HashCode={0},Name={1}",stu.GetHashCode(),stu.Name);
        }
    }

    class Student
    {
        public string Name { get; set; }
    }

}
