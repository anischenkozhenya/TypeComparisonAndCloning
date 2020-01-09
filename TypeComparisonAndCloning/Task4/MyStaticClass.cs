using System.Collections.Generic;

namespace Task4
{
    public class MyStaticClass
    {
        public static string UniqueInOrder(string originalDataStructure)
        {
            List<char> result = new List<char>();
            char prev = default;
            foreach (var item in originalDataStructure)
            {
                if (!item.Equals(prev))
                {
                    result.Add(item);
                    prev = item;
                }
            }
            return new string(result.ToArray());
        }
        public static List<T> UniqueInOrder<T>(List<T> originalDataStructure)
        {
            List<T> result = new List<T>();
            T prev = default;
            foreach (var item in originalDataStructure)
            {
                if (!item.Equals(prev))
                {
                    result.Add(item);
                    prev = item;
                }
            }
            return result;
        }
    }
}
