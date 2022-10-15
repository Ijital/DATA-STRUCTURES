
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DATA_STRUCTURES.ARRAYS
{
    /// <summary>
    /// This class has examples of questions that require find a pair of (or mutiple pairs of items in an array. 
    /// </summary>
    public class TwoItems
    {
        public TwoItems()
        {
            string reversedName = Reverse_String_Iteratively("MELVINi");
            Debugger.Break();
        }


        //  Get the reverse of a given string. This involves matching two items located a mirror positions
        //  and swaping them. This question can also come in the form like; write a method that takes a string
        //  and returns true or false indicating wether the string is a Palindrom. This would mean looping 
        //  and checking that    myString[i] == myString[myString-i-1], once a false is encountered 
        //  then it is not a palindrome
        string Reverse_String_Iteratively(string myString)
        {
            var s = myString.ToArray();

            for (int i = 0; i < myString.Length / 2; i++)
            {
                char temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }

            return String.Join(" ", s);
        }



        // Get the reverse of a given string. This involves swaping two items located a mirror positions.
        // Using recursion
        string Reverse_String_Recursively(string myString)
        {
            if (myString.Length == 1 || string.IsNullOrWhiteSpace(myString))
            {
                return myString;
            }

            return myString[myString.Length - 1] + Reverse_String_Recursively(myString.Substring(0, myString.Length - 1));
        }


        //  Given an int array A, find the two items that sum up to int K.
        //  Return values. This is appropraite for when the array is not sorted.
        // Where an array is sorted you may use two pointers. 
        KeyValuePair<int, int> Get_Two_Items_That_Sum_Up_To_K(int[] A, int K)
        {
            Dictionary<int, int> neededValues = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (neededValues.TryGetValue(A[i], out int index))
                {
                    return new KeyValuePair<int, int>(A[i], A[index]);
                }
                else
                {
                    neededValues.Add(K - A[i], i);
                }

            }
            return new KeyValuePair<int, int>();
        }


        //  Q:  Given an integer arrays A[] find two items in the array which produce the highest sum
        //  Solution:-
        //  The simple strategy here is to find the highest item and the second 
        //  highest item in the array as the two would certainly produce the highest sum
        int[] Two_Values_That_Produce_Highest_Sum(int[] A)
        {
            int highest = A[0];
            int secondHighest = A[0];

            for (int i = 0; i < A.Length; i++)
            {
                int CurrentValue = A[i];

                if (CurrentValue > highest)
                {
                    secondHighest = highest;
                    highest = CurrentValue;

                }
                else if (CurrentValue > secondHighest)
                {
                    secondHighest = CurrentValue;
                }
            }
            return new[] { highest, secondHighest };

        }


        //  Q: Given two integer arrays A[] and B[], find two items X and Y, X from A[] and Y from B[]
        //  such that the value of (X + Y) is not present in any of the two arrays.
        //  Solution:-
        //  As the previous question, the simple strategy here is to find the highest value in each of the two arrays.
        //  since there is no way the two highest values can add up to produce any lesser values         
        int[] Two_Values_From_Two_Arrays_That_Produce_Highest_Sum(int[] A, int[] B)
        {
            int highestA = A[0];
            int highestB = B[0];

            int maxIterations = A.Length > B.Length ? A.Length : B.Length;

            for (int i = 0; i < maxIterations; i++)
            {
                if (i < A.Length)
                {
                    highestA = Math.Max(highestA, A[i]);
                }

                if (i < B.Length)
                {
                    highestB = Math.Max(highestB, B[i]);
                }
            }
            return new[] { highestA, highestB };

        }


        // Q:   Check if there exist two elements in an array whose sum is equal to the sum of rest of the array
        //      It two parts of something are equal to eachother.
        //      
        int[] Two_Items_Sum_Equal_Sum_Of_Rest_Of_Array(int[] A)
        {
            int sum = A.Sum();
            if (sum % 2 != 0)
            {
                return null;
            }

            Dictionary<int, int> neededValues = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {

                if (neededValues.TryGetValue(A[i], out int index))
                {
                    return new int[] { A[i], A[index] };
                }
                else
                {
                    neededValues.Add(sum / 2 - A[i], i);
                }
            }
            return null;
        }


        //  Q:  Given an array A[] of integers, write a program to find the maximum difference between any two elements such that
        //  the larger element appears after the smaller element.In other words. This is a different way of asking the 
        //  Maximum profit question 
        //  Solution:
        //  The maximum difference would involve finding the smallest and biggest values in the array making sure 
        //  that the smallest value is at an index less than the index of the biggest value.

        int[] Max_Difference_Of_Two_Items(int[] A)
        {
            int p1 = 0;
            int highestIndex = 0;
            int highest = A[p1];
            int p2 = 0;
            int lowest = A[p2];

            while (p1 < A.Length)
            {
                if (A[p1] > highest)
                {
                    highest = A[p1];
                    highestIndex = p1;
                }
                p1++;
            }

            while (p2 < A.Length)
            {
                if (p2 == highestIndex)
                {
                    break;
                }
                if (A[p2] < lowest)
                {
                    lowest = A[p2];
                }
                p2++;
            }
            return new int[] { lowest, highest };
        }


        //  Q:  Given an array A[] of integers, write a program to find the maximum difference between any two elements such that
        //  the larger element appears after the smaller element.In other words. This is a different way of asking the 
        //  Maximum profit question 
        //  Solution:
        //  The maximum difference would involve finding the smallest and biggest values in the array making sure 
        //  that the smallest value is at an index less than the index of the biggest value.
        int[] Two_Items_Max_Difference2(int[] A)
        {
            int minValue = 0;
            int maxDifference = A[1] - A[0];

            int highestIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] - minValue > maxDifference)
                {
                    maxDifference = A[i] - minValue;
                    highestIndex = i;
                }
                if (A[i] < minValue)
                {
                    minValue = A[i];
                    minIndex = i;

                }
            }
            return new int[] { A[minIndex], A[highestIndex] };
        }


        //  Find equilibrium index of an array. The is the index that divides the array
        //  such that sun of all element on the right equal to sum of all element to the right
        int Get_Equilibrium_Index(int[] A)
        {
            int i = 0;
            int j = A.Length - 1;
            int sumLeft = A[i];
            int SumRIght = A[j];

            while (j - i >= 3)
            {
                if (sumLeft < SumRIght)
                {
                    sumLeft += A[++i];
                    continue;
                }
                if (sumLeft > SumRIght)
                {
                    SumRIght += A[--j];
                    continue;
                }
                sumLeft += A[++i];
                SumRIght += A[--j];
            }
            return j - 1;
        }


        //Finding sum of digits of a number until sum becomes single digit
        int Get_Sum_Of_Digits_Of_Num(int N)
        {
            int sum = 0;
            while (N > 0)
            {
                sum += N % 10;
                N /= 10;
                if (N == 0 && sum >= 10)
                {
                    N = sum;
                    sum = 0;
                }

            }
            return sum;
        }



        //Compute sum of digits in all numbers from 1 to n
        int Sum_All_Numbers_From_1_To_N(int N)
        {
            if (N == 1)
            {
                return N;
            }
            return N + Sum_All_Numbers_From_1_To_N(N - 1);
        }


        //  Given an integer array nums, return an array answer such
        //  that answer[i] is equal to the product of all the elements of nums except nums[i].
        //  You must write an algorithm that runs in O(n) time and without using the division operation.
        //  https://www.geeksforgeeks.org/a-product-array-puzzle/
        int[] B = new int[] { 1, 2, 3, 4 };


        //  Given two strings str1 and str2 of size m and n, write a program to check whether the two given strings are anagrams
        //  of each other or not. String str1 is an anagram of str2 if characters of str1 can be rearranged to form str2. In other
        //  words, an anagram of a string is another string that contains same characters in different order

        string name1 = "Melvin"; string name2 = "nivelM";
        bool Are_Two_Strings_Ananograms(string str1, string str2)
        {

            HashSet<char> seenChars = new HashSet<char>(str1);

            foreach (char item in str2)
            {
                if(seenChars.TryGetValue(item, out char val))
                {
                    seenChars.Remove(item);
                }
            }

            return seenChars.Count() == 0;
        }


        static int[] GetMutiples(int[] A)
        {


            return null;
        }

    }
}
