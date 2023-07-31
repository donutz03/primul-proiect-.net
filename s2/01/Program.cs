//using System;
//using System.Security.Cryptography;

//namespace NameSpaceProgram
//{
//    internal class Program
//    {
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

//private static void SystemDataTypes()
//{
//    Console.Write("First Name: ");
//    string firstName = Console.ReadLine();

//    DateTime currentTime = DateTime.Now;

//    Console.WriteLine("Hello {0}! Today is {1}.", firstName, currentTime);

//    Console.ReadLine();
//}

//public static void Main(string[] args)
//{
//    foreach (string arg in args)
//    {
//        Console.WriteLine("Argument: {0}", arg);


//    }
//    SystemDataTypes();
//}

//        private static void Main(string[] args)
//        {
//            string s1 = "abc";
//            string s2 = s1;
//            s1 = s1.Replace("abc", "ba");
//            Console.WriteLine(s1);
//            Console.WriteLine(s2);

//            Console.WriteLine("-----------------------");
//            String str3 = "abc";
//            String s4 = str3;
//            str3 += "d";
//                Console.WriteLine(str3);
//                Console.WriteLine(s4);

//        }


//    }

//}


using System;
using System.Diagnostics;
using System.Text;

namespace ExempluString
{
    internal class Program
    {
        //private static void Main(string[] args)
        //{
        //    string a = "hello";
        //    string b = "h";

        //    b += "ello";

        //    Console.WriteLine(a == b);
        //    Console.WriteLine((object)a == b);
        //}


        //private static void StringBuilderPerformance()
        //{
        //    Console.WriteLine("###StringBuilderPerformance");


        //    const int noOfRepetitions = 50000;

        //    var regularString = string.Empty;

        //    var watch = Stopwatch.StartNew();
        //    for (var i = 0; i < noOfRepetitions; i++)
        //    {
        //        regularString += "a";
        //    }

        //    watch.Stop();
        //    var elapsedMs = watch.ElapsedMilliseconds;

        //    Console.WriteLine("Using System.String: {0}ms", elapsedMs);

        //    var stringBuilder = new StringBuilder();

        //    watch = Stopwatch.StartNew();

        //    for (var i = 0; i < noOfRepetitions; i++)
        //    {
        //        stringBuilder.Append("a");
        //    }

        //    regularString = stringBuilder.ToString();
        //    watch.Stop();
        //    elapsedMs = watch.ElapsedMilliseconds;

        //    Console.WriteLine("Using System.Text.StringBuilder: {0}ms", elapsedMs);

        //    Console.ReadLine();





        //}



        private static void Main(string[] args)
        {
            //StringBuilderPerformance();
            //Arrayz();
            RectangularArray();
        }

        public static void Arrayz()
        {
            int[] intArray;

            intArray = new int[3];

            var doubleArray = new[] { 34.23, 10.2, 23.2 };

            var arrayElement = doubleArray[0];
            doubleArray[1] = 5.55;

            for (var i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);

            foreach (var value in doubleArray)
                Console.WriteLine(value);

            Array.Sort(doubleArray);

            for (var i = 0; i < doubleArray.Length; i++)
                Console.WriteLine("doubleArray[{0}]={1}", i, doubleArray[i]);

        }

        private static void RectangularArray()
        {
            var cub = new int[5, 2, 7];

            var matrix = new[,] {
                                {4, 23, 5, 2},
                                { 1, 6, 13, 29}
                                };


            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(" {0}", matrix[i, j]);
                Console.WriteLine();
            }
        }

        private void JaggedArray()
        {
            int[][] jaggedArray =
            {
                new int[] {0, 1, 2},
                new int[] {3, 4},
                new int[] {6, 7 ,8 , 9}
            };
        }
        

    }
}