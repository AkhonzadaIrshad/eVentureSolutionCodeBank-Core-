using System;
using System.Collections.Generic;
using System.Linq;

namespace TextSummarizerDemo
{


    class WordsWithCount
    {
        public string wordText;
        public int count;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var wordsWithCounts = new List<WordsWithCount>();
            const string paragraph = @"One hot day, a thirsty crow flew all over the fields looking for water. For a long time, he could not find any. He felt very weak, almost lost all hope. Suddenly, he saw a water jug below the tree. He flew straight down to see if there was any water inside. Yes, he could see some water inside the jug!

The crow tried to push his head into the jug. Sadly, he found that the neck of the jug was too narrow. Then he tried to push the jug to tilt for the water to flow out, but the jug was too heavy.

The crow thought hard for a while. Then, looking around it, he saw some pebbles. He suddenly had a good idea. He started picking up the pebbles one by one, dropping each into the jug. As more and more pebbles filled the jug, the water level kept rising. Soon it was high enough for the crow to drink. His plan had worked!

Moral: Think and work hard, you may find solution to any problem.";
            var words = paragraph.Split(' ');
            foreach (var word in words)
            {
                var tempWord = word.Clone().ToString().Replace('.', ' ').Trim();
                var count = words.Count(wrd => tempWord == wrd.Replace('.', ' ').Trim());
                if (!wordsWithCounts.Exists(x => x.wordText.Equals(tempWord)))
                {
                    wordsWithCounts.Add(new WordsWithCount { count = count, wordText = tempWord });
                }
            }

            foreach (WordsWithCount wordsWithCount in wordsWithCounts)
            {
                Console.WriteLine($"{wordsWithCounts.IndexOf(wordsWithCount) + 1}:  Word : {wordsWithCount.wordText}  Count: {wordsWithCount.count}");
            }
            var sentences = paragraph.Split('.');
            var max = wordsWithCounts.Max(x => x.count);
            wordsWithCounts.Sort((x, y) => x.count.CompareTo(y.count));
            var withHighestOccurence = wordsWithCounts.Where(x => x.count == max).ToList();
            var toPrint = new List<string>();
            foreach (var oc in withHighestOccurence)
            {
                var text = sentences.Where(x => x.Contains(oc.wordText)).ToList();
                toPrint.AddRange(text);
            }
            foreach (string text in toPrint)
            {
                Console.WriteLine(text);
            }


            Console.ReadKey();
        }
    }
}
