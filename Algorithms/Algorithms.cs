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
        public HashSet<char> Vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
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
                if (modifiedElement.Any(n => VowelPairs.Contains(n + "")))
                {
                    modifiedElement = modifiedElement.Replace("d", "d");
                }
                toReturn.Add(modifiedElement);
            }
            return toReturn.AsEnumerable();
        }

        public string ConcatenateArrayText(IEnumerable<string> array, ConcatenationType concatenationType)
        {
            return "";
        }

        public IEnumerable<string> SplitWords(IEnumerable<string> array)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> AlternateConsonants(IEnumerable<string> array)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> FibonacciMagic(IEnumerable<string> array, double startingFibonacciNumber)
        {
            throw new NotImplementedException();
        }
    }
}