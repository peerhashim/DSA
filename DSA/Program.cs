using DSA.Problems.arrays;
namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            // Two Sum Brute Force -- leetcode 1

            /*var result = Arrays.TwoSumB(new int[] { 12, 2 }, 9);
            */

            // Two Sum Optimized -- leetcode 1
            var result = Arrays.TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);

            PrintAny(result);
        }
        static void PrintAny(object? result)
        {
            if (result == null)
            {
                Console.WriteLine("null");
                return;
            }

            // Handle collections (array, list, etc.)
            if (result is System.Collections.IEnumerable enumerable && result is not string)
            {
                Console.Write("[ ");
                bool first = true;

                foreach (var item in enumerable)
                {
                    if (!first) Console.Write(", ");
                    Console.Write(item);
                    first = false;
                }

                Console.WriteLine(" ]");
                return;
            }

            // Handle objects, tuples, anonymous types, primitives
            Console.WriteLine(result);
        }

    }


}
