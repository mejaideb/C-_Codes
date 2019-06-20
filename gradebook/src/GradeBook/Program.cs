using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new [] {11.5,12.45,44.2};
            var result=0.0;
            foreach(var i in grades)
            {
                result +=i;

            }
            Console.WriteLine(result);
            Console.WriteLine("Hello World!");
        }
    }   
}
