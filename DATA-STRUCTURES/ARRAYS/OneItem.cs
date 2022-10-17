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

        public OneItem()
        {
            //var result = Get_First_Recurring_Value(Data.ArrayA);

            //var result1 = Find_The_Item_Occuring_Once(nums);

            var getSum = Get_Number_Of_Elements(arr);

            Debugger.Break();
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

            if (sortedNums.Count == 0)
            {
                return -1;
            }
            return sortedNums.Last().Key;
        }


        //  Given an integer array arr, count how many elements x there are, such that x + 1 is also in arr.
        //  If there are duplicates in arr, count them separately.

        int[] arr = new int[] { 1, 1, 2, 2 };
        int Get_Number_Of_Elements(int[] arr)
        {

            foreach (var item in arr)
            {

            }
     
      
            return 0;
        }

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

    }
}

