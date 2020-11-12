using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From teacher");

            Singleton fromEstudent = Singleton.GetInstance;
            fromEstudent.PrintDetails("From student");

            Console.ReadLine();
        }
    }
}
