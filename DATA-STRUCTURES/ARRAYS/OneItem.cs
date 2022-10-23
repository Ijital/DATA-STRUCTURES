using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DATA_STRUCTURES.ARRAYS
{
    /// <summary>
    /// This class has examples of questions that require find a single item in an array. 
    /// </summary>
    public class OneItem
    {
        int[] arr = new int[] {1,2,3,4,5, 6, 7, 8, 9};
        public OneItem()
        {
            Seperate_Negative_Positive_Elements(arry2);


            Debugger.Break();
        }

        // Rotate an array of integers A for K number of times in Anti clockwise direction       
        int[] Get_Rotated_Array(int[] A, int K)
        {
            int indexOffset = K % A.Length;

            int[] newArray = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                if (i + indexOffset < A.Length)
                {
                    newArray[i + indexOffset] = A[i];
                }
                else
                {
                    int index = i + indexOffset - A.Length;

                    newArray[index] = A[i];
                }              
            }

            return newArray;
        }


        // Rotate an array K number of times in clockwise
        int[] Get_Rotated_ArrayClockwise(int[] A, int K)
        {
            int indexOffset = K % A.Length;

            int[] newArray = new int[A.Length];

            for (int i = A.Length-1; i>=0; i--)
            {
                if (i - indexOffset > 0)
                {
                    newArray[i - indexOffset] = A[i];
                }
                else
                {
                    int index = i - indexOffset + A.Length-1;

                    newArray[index] = A[i];
                }

            }

            return newArray;
        }

        // Find first recurring item in an array
        private static int? Get_First_Recurring_Value(int[] arr)
        {
            HashSet<int> seenValues = new HashSet<int>();

            foreach (var item in arr)
            {
                if (seenValues.TryGetValue(item, out int value))
                {
                    return value;
                }
                seenValues.Add(item);
            }
            return null;
        }

        //  Given an array of integers. All numbers occur twice except one number which occurs once.Find the number in O(n)
        //  time & constant extra space. Find first recurring item in an array
        int[] nums = new int[] { 2, 3, 4, 2, 3, 4, 5 };
        private static int Find_The_Item_Occuring_Once(int[] arr)
        {
            HashSet<int> seenValues = new HashSet<int>();

            foreach (var item in arr)
            {
                if (seenValues.TryGetValue(item, out int value))
                {
                    seenValues.Remove(item);
                }
                else
                {
                    seenValues.Add(item);
                }
            }
            return seenValues.ElementAt(0);
        }

        //Given an integer array nums, return the largest integer that only occurs once. If no integer occurs once, return -1.
        int[] numsA = new int[] { 5, 7, 3, 9, 4, 9, 8, 3, 1, 8, 7 };

        int Get_Largest_SingleOcurring_Number(int[] nums)
        {
            if (nums.Length == 0)
            {
                return -1;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }

            if(nums.Length== 2)
            {
                return nums[0] == nums[1]? -1: Math.Max(nums[0], nums[1]);
            }

            SortedList<int, int> sortedNums = new SortedList<int, int>();

            HashSet<int>deletedNums= new HashSet<int>();
        
            foreach (var item in nums)
            {
                if (sortedNums.TryGetValue(item, out int val) || deletedNums.TryGetValue(item, out int rVal))
                {
                    sortedNums.Remove(item);
                    deletedNums.Add(item);
                }
                else
                {
                    sortedNums.Add(item, val);
                }
            }
            return sortedNums.Count == 0 ? -1 : sortedNums.Last().Key;
        }

        // TO DO
        //  Given an integer array arr, count how many elements x there are, such that x + 1 is also in arr.
        //  If there are duplicates in arr, count them separately.

        //int[] arr = new int[] { 1, 1, 2, 2 };
        int Get_Number_Of_Elements(int[] arr)
        {
            foreach (var item in arr)
            {

            }     
            return 0;
        }

        //
        public bool CheckIfPangram(string sentence)
        {
            HashSet<char> uniqChars = new HashSet<char>(); 

            foreach (var item in sentence)
            {
                if(Char.IsLetter(item))
                {
                    uniqChars.Add(item);
                }
            }
            return uniqChars.Count ==26;

        }

        // If an array is sorted then it is more efficient to use binary search. 
        // Binary search involes picking a middle item, compary it with the target value
        // If the middle item is less that the target value then you pick the middle item 
        // from first item to the last muiddle. You contiune untill you arrive at the target value
        // BIG O = O(LOG N)

        // Question that can be asked here is, can there be duplicate items? If there are duplicates 
        // then the question would, if we are required to find the first occurance of the itme.

        int[] sortedNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static private int GetItemByBinary(int[] nums, int target)
        {
            int lowerBoundery = 0;

            int upperBoundery = nums.Length - 1;

            while (lowerBoundery < upperBoundery)
            {
                if (nums[lowerBoundery] == target)
                {
                    return lowerBoundery;
                }

                if (nums[upperBoundery] == target)
                {
                    return upperBoundery;
                }

                int mid = (upperBoundery + lowerBoundery) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (target > nums[mid])
                {
                    lowerBoundery = mid;
                }
                else if (target < nums[mid])
                {
                    upperBoundery = mid;
                }

            }
            return -1;
        }

        // Given an array arr[] of size N, the task is to find the maximum possible sum of i*arr[i]
        // when the array can be rotated any number of times. Solution could be to rotate the array untill
        // the largest item in the array 


        // Given an array of integers, update every element with the multiplication of previous and next
        // elements with the following exceptions.
        // (a) The First element is replaced the by multiplication the of first and second.
        // (b) The last element is replaced by multiplication of the last and second last

        int[] arry = { 2, 3, 4, 5, 6 };

        //{6, 8, 15, 24, 30}
        void Update_Arrange(int[] A)
        {
            int previous = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0)
                {
                    previous = A[0];
                    A[i] *= A[i + 1];

                }
                else if (i == A.Length - 1)
                {
                    A[i] *= previous;
                }
                else
                {
                    int temp = A[i];
                    A[i] = previous * A[i+1];
                    previous= temp;
                }
            }
        }

        // Given an unsorted array arr[] of both negative and positive integer.The task is place all
        // negative element at the end of array without changing the order of positive element and negative element.
        int[] arry2 = { 1, -1, 3, 2, -7, -5, 11, 6 };

        //1  3  2  11  6  -1  -7  -5 

        void Seperate_Negative_Positive_Elements(int[] A)
        {
            int[] range = new int[A.Length];
            int nextRange = 0;
            int nextItem = 0;

            for (int x = 0; x < A.Length; x++)
            {
                if (A[x] >= 0)
                {
                    A[nextItem++] = A[x];
                }
                else
                {
                    range[nextRange++] = A[x];
                }
            }
            foreach (var item in range)
            {
                if (item < 0)
                {
                    A[nextItem++] = item;
                }
            }

        }

    }
}
