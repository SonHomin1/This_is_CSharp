using System;
using static System.Console;

namespace StringFormatBasic
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string fmt = "{0,-20}{1,-15}{2, 30}";

            Console.WriteLine(fmt, "Publisher", "Author", "Title");
            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            
        }
    }
}
