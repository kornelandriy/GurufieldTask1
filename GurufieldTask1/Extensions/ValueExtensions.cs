using System.Collections.Generic;

namespace GurufieldTask1.Extensions
{
    public static class ValueExtensions
    {
        private static readonly Dictionary<int, string> Dividers = new Dictionary<int, string>
        {
            {3, "Foo"},
            {5, "Bar"}
        };

        public static string Filter(this int value)
        {
            foreach (var divider in Dividers)
                if (value % divider.Key == 0)
                {
                    return divider.Value;
                }
            return value.ToString();
        }
    }
}