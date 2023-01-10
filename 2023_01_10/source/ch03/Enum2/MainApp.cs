using System;

namespace Enum2
{
    class MainApp
    {
        enum DialogResult { YES, NO, CENCEL, CONFIRM, OK }
        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CENCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);
        }
    }
}
