﻿using System;

namespace Object
{
    class MainApp
    {
        static void Main(string[] args)
        {
            object a = 123;
            object b = 3.141592653589793238462643383279m;// m은 decimal
            object c = true;
            object d = "안녕하세요.";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
