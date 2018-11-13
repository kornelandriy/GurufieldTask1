using System;
using GurufieldTask1.Extensions;

namespace GurufieldTask1
{
    internal class Program
    {
        private static void Main()
        {
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(i.Filter());
            }
        }
    }
}