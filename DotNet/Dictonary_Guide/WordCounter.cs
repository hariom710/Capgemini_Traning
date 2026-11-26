using System;
using System.Collections.Generic;
namespace Dictonary_Guide
{
    public class WordCounter
    {
        private Dictionary<string, int> wordCounts;

        public WordCounter()
        {
            wordCounts = new Dictionary<string, int>();
        }

        public void AddWord(string word)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts[word] = 1;
            }
        }

        public int GetCount(string word)
        {
            if (wordCounts.ContainsKey(word))
            {
                return wordCounts[word];
            }
            else
            {
                return 0;
            }
        }

        public void PrintAllCounts()
        {
            foreach (var pair in wordCounts)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}