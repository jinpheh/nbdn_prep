using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.tests.utility
{
    public static class Iteration
    {
        public static void each<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items) action(item);
        }

        public static IEnumerable<int> to(this int start, int end)
        {
            for (var i = start; i <= end; i++) yield return i;
        }
    }
}