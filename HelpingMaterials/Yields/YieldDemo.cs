using System.Collections.Generic;

namespace HelpingMaterials.Yields
{
    class YieldDemo
    {
        //static void Main(string[] args)
        //{
        //    Random random = new Random();

        //    foreach (var value in GetRandomInRange(5, 105))
        //    {
        //        Console.WriteLine(value);
        //    }
        //    Console.ReadKey();

        //}

        static IEnumerable<int> GetRandomInRange(int start, int end)
        {
            for (; start < end; start++)
            {
                yield return start;
            }
        }
    }
}