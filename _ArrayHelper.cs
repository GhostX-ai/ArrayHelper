using System;

namespace ArrayHelper
{
    static class _ArrayHelper_
    {
        public static string Pop(ref string[] ar)
        {
            string[] nar = new string[ar.Length - 1];
            for (int x = 0; x < ar.Length - 1; x++)
            {
                nar[x] = ar[x];
            }
            string end = ar[ar.Length - 1];
            ar = nar;
            return end;
        }
        public static double Pop(ref double[] ar)
        {
            double[] nar = new double[ar.Length - 1];
            for (int x = 0; x < ar.Length - 1; x++)
            {
                nar[x] = ar[x];
            }
            double end = ar[ar.Length - 1];
            ar = nar;
            return end;
        }
        public static int Pop(ref int[] ar)
        {
            int[] nar = new int[ar.Length - 1];
            for (int x = 0; x < ar.Length - 1; x++)
            {
                nar[x] = ar[x];
            }
            int end = ar[ar.Length - 1];
            ar = nar;
            return end;
        }
        public static decimal Pop(ref decimal[] ar)
        {
            decimal[] nar = new decimal[ar.Length - 1];
            for (int x = 0; x < ar.Length - 1; x++)
            {
                nar[x] = ar[x];
            }
            decimal end = ar[ar.Length - 1];
            ar = nar;
            return end;
        }
        public static void Push(ref string[] ar, string ne)
        {
            string[] nar = new string[ar.Length + 1];
            for (int x = 0; x < ar.Length; x++)
            {
                nar[x] = ar[x];
            }
            nar[nar.Length-1] = ne;
            ar = nar;
        }
        public static void Push(ref double[] ar, double ne)
        {
            double[] nar = new double[ar.Length + 1];
            for (int x = 0; x < ar.Length; x++)
            {
                nar[x] = ar[x];
            }
            nar[nar.Length-1] = ne;
            ar = nar;
        }
        public static void Push(ref int[] ar, int ne)
        {
            int[] nar = new int[ar.Length + 1];
            for (int x = 0; x < ar.Length; x++)
            {
                nar[x] = ar[x];
            }
            nar[nar.Length-1] = ne;
            ar = nar;
        }
        public static void Push(ref decimal[] ar, decimal ne)
        {
            decimal[] nar = new decimal[ar.Length + 1];
            for (int x = 0; x < ar.Length; x++)
            {
                nar[x] = ar[x];
            }
            nar[nar.Length-1] = ne;
            ar = nar;
        }
        
    }
}