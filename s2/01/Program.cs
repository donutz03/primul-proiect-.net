using System;

namespace NameSpaceProgram
{
    internal class Program
    {
        //private static void Main(string[] args)
        //{
        //    Console.WriteLine("hello world!");
        //    Console.ReadLine();
        //    int foo = 10;
        //    int bar = 20;
        //    Console.WriteLine("foo: " + foo + " bar: " + bar);
        //    Console.WriteLine("foo: {0} bar: {1}", foo, bar);
        //    Console.WriteLine("{1}, {0}, {2}", 10, 20, 30);
        //    Console.WriteLine($"{foo}" + " and " + $"{bar}");
        //    Console.WriteLine("c format: {0:c}", foo);




        //}

        //static int Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //    Console.ReadLine();

        //    return -1;
        //}

        public static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine("Argument: {0}", arg);
            }
        }

    }

}