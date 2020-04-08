using System;

namespace ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4 };
            System.Console.WriteLine("----List init-----");
            foreach (var z in x)
            {
                System.Console.WriteLine(z);
            }
            System.Console.WriteLine("----List after Pop method-----");
            int end = _ArrayHelper_.Pop(ref x);
            foreach (var z in x)
            {
                System.Console.WriteLine(z);
            }
            System.Console.WriteLine($"deleted {end}");
            System.Console.WriteLine("----List after Push method-----");
            _ArrayHelper_.Push(ref x, 6);
            foreach (var z in x)
            {
                System.Console.WriteLine(z);
            }
            System.Console.WriteLine("----List after Shift method-----");
            int fs = _ArrayHelper_.Shift(ref x);
            foreach (var z in x)
            {
                System.Console.WriteLine(z);
            }
            System.Console.WriteLine($"deleted {fs}");
            System.Console.WriteLine("----List after UnShift method-----");
            _ArrayHelper_.UnShift(ref x, 8);
            foreach (var z in x)
            {
                System.Console.WriteLine(z);
            }
            Console.ReadKey();
        }
    }
}
