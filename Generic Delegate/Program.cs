using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate
{

    public delegate void VoidSimpleDelegate();

    public delegate void MyAction<in T1>(T1 t1);
    public delegate void MyAction<in T1,in T2>(T1 t1, T2 t2);
    public delegate void MyAction<in T1, in T2,in T3>(T1 t1, T2 t2, T3 t3);

    public delegate T1 MyFunction<out T1>();
    public delegate T2 MyFunction<in T1, out T2>(T1 t1);
    public delegate T3 MyFunction<in T1, in T2 ,out T3>(T1 t1, T2 t2);


    class Program
    {
        static void Main(string[] args)
        {
            VoidSimpleDelegate myMethod = () => { };
            myMethod();

            //Add 2 number and sbstract third
            MyAction<int, int, int> myAction1 = (a, b, c) =>
              {
                  Console.WriteLine(a + b - c);
              };
            myAction1(6,1,2);

            // Get student name, grade and age - print name and "very smart" if age < grade -20

            MyAction<string, int, int> printSmart = (name, grade, age) =>
             {
                 if (age < grade - 20)
                 {
                    Console.WriteLine($"{name} very smart!");
                 }
             };
            printSmart("fabi", 100,25);

           

            //Student Creator Function
            MyFunction<int,string,Student> studentCreatoFunction = 
                (id,name) =>   new Student() { Name = name, Id = id };

           var student1 =  studentCreatoFunction(312, "Fabi");
            Console.WriteLine(student1.Name);

            MyFunction<int, int, int> add = (a, b) => a + b;
            MyFunction<int, int, int> sub = (a, b) => a - b;

            add(100, 30);
            sub(100, 30);


        }
        class Student
        {
            public string Name { get; set; }
            public int Id { get; set; }

        }
    }
}
