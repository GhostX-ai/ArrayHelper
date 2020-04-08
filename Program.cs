using System;

namespace ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = { "Asd", "Sds" };
            string end = _ArrayHelper_.Pop(ref x);
            _ArrayHelper_.Push(ref x,"NE");
            string fs = _ArrayHelper_.Shift(ref x);
            Console.ReadKey();
        }
    }
}
