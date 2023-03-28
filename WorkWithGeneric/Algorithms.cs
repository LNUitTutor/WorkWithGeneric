using System;
using System.Collections.Generic;

namespace WorkWithGeneric
{
    public static class Algorithms
    {
        public static double TotalVolume<T>(IEnumerable<T> objects) where T : IVolumable
        {
            double Sum = 0.0;
            foreach(T obj in objects) Sum += obj.Volume();
            return Sum;
        }
        public static void PrintAll<T>(IEnumerable<T> col)
        {
            foreach (T inst in col) Console.WriteLine(inst);
        }
        public static void DoWithEachl<T>(IEnumerable<T> col, Action<T> action)
        {
            foreach (T inst in col) action(inst);
        }
        public static TOut Accumulate<TIn, TOut>(IEnumerable<TIn> col, Func<TIn, TOut, TOut> func) where TOut: new()
        {
            TOut res = new();
            foreach (TIn c in col) res = func(c, res);
            return res;
        }

    }
}
