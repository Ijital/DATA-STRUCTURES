
using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Policy;
using System.Text;

namespace DATA_STRUCTURES.ARRAYS
{
    //A subsequence is a sequence that can be derived from another sequence by removing zero or more elements,
    //without changing the order of the remaining elements.
    public class SubSequence
    {
        public SubSequence()
        {
            bool isIt =  Is_String_SubSequence_Of_Another("Melvin", "in");

            Debugger.Break();   
        }

        //Given two strings S and T, return true if S is a subsequence of T, or false otherwise.
        //A subsequence of a string is a new string that is formed from the original string by deleting some(can be none)
        //of the characters without disturbing the relative positions of the remaining characters.
        //(i.e., "ace" is a subsequence of "abcde" while "aec" is not).
        // The method Equals. 
        bool Is_String_SubSequence_Of_Another(string T, string S)
        {
            int CharCounter = 0;

            foreach (char item in T)
            {
                if (item == S[CharCounter])
                {
                    CharCounter++;
                }
                if (CharCounter == S.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
