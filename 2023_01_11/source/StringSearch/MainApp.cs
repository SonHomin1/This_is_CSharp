using System;

namespace StringSearch
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            Console.WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            Console.WriteLine("IndexOf 'o' : {0}", greeting.IndexOf("o"));

            Console.WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            Console.WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

            Console.WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            Console.WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            Console.WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            Console.WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            Console.WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            Console.WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            Console.WriteLine("Replaced 'Morning' with 'Evening': {0}", greeting.Replace("Morning", "Evening"));

        }
    }
}
