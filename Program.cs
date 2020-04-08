using System;

namespace ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = { "Asd", "Sds" };
            string end = _ArrayHelper_.Pop(ref x);
            Console.ReadKey();
        }
    }
}
