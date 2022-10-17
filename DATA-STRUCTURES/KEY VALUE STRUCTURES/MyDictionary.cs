using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DATA_STRUCTURES.DICTIONARY
{
    // The Dictionary Data structure has the following time complexity
    //  ==============================================================
    //  this[key]........................................O(1)
    //  this.Add(key, value) ............................O(1) or O(N)
    //  this.Remove(key)................................ O(1)   
    //  this.ContainsKey(key)............................O(1)  
    //  this.ContainsValue(value)........................O(N)
    //  this.TryGetValue(T key, K out value).............O(1)
    //  ==================================================================
    public class MyDictionary
    {
        string[] mywords = new string[] { "practice", "makes", "perfect", "coding", "makes" };
        public MyDictionary()
        {


            Debugger.Break();
        }

        //Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.
        //You can use each character in text at most once.Return the maximum number of instances that can be formed.
        public int Get_Max_Number_Of_Balloons(string text)
        {

        Dictionary<char, int> chars = new Dictionary<char, int>
        {
            {'b', 0 },
            {'a', 0 },
            {'l', 0 },
            {'o', 0 },
            {'n', 0 }
        };


            foreach (char c in text)
            {
                if (chars.TryGetValue(c, out int val))
                {
                    chars[c] = val + 1;
                }
            }

            int minOfDoubles = Math.Min(chars['l'] / 2, chars['o'] / 2);

            int minOfRest = Math.Min(Math.Min(chars['b'], chars['a']), chars['n']);

            return Math.Min(minOfDoubles, minOfRest);
        }

    }

    public class WordDistance
    {
        string[] words;

        public WordDistance(string[] wordsDict)
        {
            this.words = wordsDict;
        }

        public int Shortest(string word1, string word2)
        {
            string wordCombo1 = word1 + word2;
            string wordCombo2 = word2 + word1;
            string leftWord = string.Empty;
            int distance = words.Length-1;
            int p1 = 0;
            int p2 = 0;


            while (p1 < words.Length)
            {
                if (leftWord + words[p1] == wordCombo1 || leftWord + words[p1] == wordCombo2)
                {
                    distance = Math.Abs(p1 - p2) < distance ? Math.Abs(p1 - p2) : distance;
                    leftWord = words[p1];
                    p2 = p1;
                    p1++;
                }

                else if (words[p1] == leftWord)
                {
                    p2 = p1;
                    p1++;
                }
                else if (words[1] == word1 || words[p1] == word2)
                {
                    leftWord = words[p1];
                    p2 = p1;
                    p1++;
                }
                else
                    p1++;


            }
            return distance;

        }
    }

}
