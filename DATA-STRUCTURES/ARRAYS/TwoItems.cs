
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Linq;

namespace DATA_STRUCTURES.ARRAYS
{
    // The Array Data structure has the following time complexity
    //  ==============================================================
    //  this[index]..........O(1)
    //  Add(key, value) .... O(1)
    //  Remove(key)......... O(N)   
    //  ==================================================================

    public class TwoItems
    {
        public TwoItems()
        {
            string reversedName = ReverseStringManaually("HANNAH");


            Debugger.Break();
        }




        #region TWO ITEMS IN ARRAY THAT EVALUATE TO A KNOWN VALUE

        // Get the reverse of a given string. This involves swaping two items located a mirror positions
        string ReverseStringManaually(string myString)
        {
            int a = myString.Length - 1;

            char[] stringChars = new char[myString.Length];

            foreach (var item in myString)
            {
                stringChars[a--] = item;
            }

            return string.Join("", stringChars);
        }

        //  Given an int array A, find the two items that sum up to int K.
        //  Return values
        static KeyValuePair<int, int> Get_Two_Items_That_Sum_Up_To_K(int[] A, int K)
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
        static int[] Two_Values_That_Produce_Highest_Sum(int[] A)
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
        static int[] Two_Values_Two_Arrays_That_Produce_Highest_Sum(int[] A, int[] B)
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
        static int[] Two_Items_Sum_Equal_Sum_Of_Rest_Of_Array(int[] A)
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

        static int[] Max_Difference_Of_Two_Items(int[] A)
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
        static int[] Two_Items_Max_Difference2(int[] A)
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
        static int Get_Equilibrium_Index(int[] A)
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
        static int Get_Sum_Of_Digits_Of_Num(int N)
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
        static int Sum_All_Numbers_From_1_To_N(int N)
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
        static int[] B = new int[] { 1, 2, 3, 4 };
        static int[] GetMutiples(int[] A)
        {


            return null;
        }
        #endregion
    }
}
