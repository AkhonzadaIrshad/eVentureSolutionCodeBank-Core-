using System;

namespace SearchStringInParagraphDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Paragraph");
            string paragraph =Console.ReadLine();
            Console.WriteLine("Enter a Keyword to search");
            string keyword =Console.ReadLine();

            string[] values = paragraph.Split(' ');
            Console.Clear();
            for (int i=0;i<values.Length;i++)
            {
                if (values[i].Equals(keyword,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Keyword {values[i]} found at index {i}");
                }
            }

            Console.ReadKey();
        }
    }
}