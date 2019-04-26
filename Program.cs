using System;
using System.Collections.Generic;
using System.Collections;

namespace list_of_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few word
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> deadWord = new Dictionary<string, string>();

            deadWord.Add("word", "dead");
            deadWord.Add("definition", "cease to be, pushing up the daisies, expired and gone to meet the maker, bereft of life");
            deadWord.Add("part of speech", "adjective");
            deadWord.Add("example", "He's dead, Jim.");

            dictionaryOfWords.Add(deadWord);
            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> item in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> word in item)
                {
                    Console.WriteLine($"{word.Key}: {word.Value}");
                }
            };
        }
    }
}
