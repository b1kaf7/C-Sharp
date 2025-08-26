using System;

namespace WordListIndexer
{
    class WordList
    {
        private string[] words;

        public WordList(string[] arr)
        {
            words = arr;
        }

        public string this[int index]
        {
            get { return words[index]; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings and Indexers");

            string[] myWords = { "Apple", "Banana", "Cherry" };
            WordList wordList = new WordList(myWords);

            // print the word at index 1
            Console.WriteLine($"Word at index 1: {wordList[1]}");
            // Output: Banana
        }
    }
}