using System;

namespace Enum2
{
    class MainApp
    {
        enum DialogResult { YES = 10, NO, CENCEL, CONFIRM = 50, OK }
        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CENCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}

