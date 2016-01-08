using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace AcklenAveApplication.Algorithms
{
    public enum ConcatenationType
    {
        Asterisks,
        ASCII
    }

    public class Algorithms
    {
        public HashSet<char> Vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y' };
        public HashSet<char> Consonants = new HashSet<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
        public HashSet<string> VowelPairs;
        public HashSet<string> EnglishWords = new HashSet<string> { "drool", "cats", "clean", "code", "dogs", "materials", "needed", "this", "is",
                                                                           "hard", "what", "are", "you", "smoking", "shot", "gun", "down", "river", "super",
                                                                           "man", "rule", "acklen", "developers", "are", "amazing" };

        public Algorithms()
        {
            BuilVowelPairs();
        }

        public void BuilVowelPairs()
        {
            foreach (var vowel in Vowels)
            {
                foreach (var vowel1 in Vowels)
                {
                    VowelPairs.Add(vowel + vowel1 + "");
                }
            }
        }

        public string Base64Encode(string plaintext)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plaintext);
            return Convert.ToBase64String(plainTextBytes);
        }

        public IEnumerable<string> SortArray(IEnumerable<string> array, bool reverse)
        {
            var list = array.ToList();
            list.Sort(StringComparer.Create(new CultureInfo("en-US"), true));
            if (reverse)
                list.Reverse();
            return list.AsEnumerable();
        }

        public IEnumerable<string> ScrambleArrayText(IEnumerable<string> array)
        {
            var list = array.ToList();
            List<string> toReturn = new List<string>();
            foreach (var element in list)
            {
                if (!element.Any(n => Vowels.Contains(n)))
                    toReturn.Add(element);
                var modifiedElement = element;
                List<string> pairs = new List<string>();
                if (VowelPairs.Any(n => modifiedElement.Contains(n)))
                {
                    
                }
                toReturn.Add(modifiedElement);
            }
            return toReturn.AsEnumerable();
        }

        public string ConcatenateArrayText(IEnumerable<string> array, ConcatenationType concatenationType)
        {
            var toReturn = "";
            if (concatenationType.Equals(ConcatenationType.Asterisks))
            {
                toReturn = array.Aggregate(toReturn, (current, element) => current + (element + "*"));
                toReturn.Remove(toReturn.Length-1);
            }
            else
            {
                for (int i = 0; i < array.Count(); i++)
                {
                    toReturn += array.ElementAt(i) + (int) char.GetNumericValue(array.ElementAt((i == 0 ? array.Count() : i) - 1).ElementAt(0));
                }
            }
            return toReturn;
        }

        public IEnumerable<string> SplitWords(IEnumerable<string> array)
        {
            var toReturn = new List<string>();
            foreach (var element in array)
            {
                foreach (var englishWord in EnglishWords)
                {
                    if (element.Equals(englishWord))
                    {
                        toReturn.Add(element);
                    }
                    else if (element.Contains(englishWord) && element.Length > englishWord.Length)
                    {
                        foreach (var word in EnglishWords.Where(word => element.Equals(word + englishWord)))
                        {
                            toReturn.Add(word);
                            toReturn.Add(englishWord);
                        }
                    }
                }
            }
            return toReturn;
        }

        public IEnumerable<string> AlternateConsonants(IEnumerable<string> array)
        {
            bool UpperCase = false;
            bool First = true;
            foreach (var element in array)
            {
                foreach (var character in element)
                {
                    if (Consonants.Contains(char.ToLower(character)))
                    {
                        if (First)
                        {
                            UpperCase = char.IsUpper(character);
                            First = false;
                        }
                        else
                        {
                            
                        }
                    }
                }
            }
            return array;
        }

        public IEnumerable<string> FibonacciMagic(IEnumerable<string> array, double startingFibonacciNumber)
        {
            throw new NotImplementedException();
        }
    }
}