
using DATA_STRUCTURES.DICTIONARY;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DATA_STRUCTURES.ARRAYS
{
    /// <summary>
    /// A subarray is a contiguous part of array, i.e., Subarray is an array that is inside another array.
    /// A Sub array can be defined using two indexes, the left and the right ends of the the sub array
    /// </summary>
    public class SubArrays
    {

        public SubArrays()
        {

          var ss =  Get_All_Sub_Arrays(nums);


           //var result =  Array_Can_Be_Split(nums);

           //var results = Is_There_Subarray_Multplying_To_K(nums, 20);

           Debugger.Break();
        }


        //Most questions about sub array will involve the following examples;
        // 1 Finding a subarray whose items sum up to a number
        // 2 Find a subarray whose items have the biggest sum. One may think that an 
        // an array is its own biggest sub array and hence the array itself is its subarray
        // that have the largest sum but we could have an array that has negative values
        // In which case summing everything will including the negative values thuse potentiall
        // Making the entire array having a smaller sum that one of its sub arrays. 

        // Some Sub Array questions can invloved finding a sub array that meets a target evaluation value
        // Some question can involve a non targeted value. E.g highest, smalled etc. 
        // NOTE: Just like we most of the time do not need to touch every item in an array to identify one
        // that meets a condition, we also do not need to check every possible sub array to find 
        // one that meets a condition. We use two pointers and move  one or both in the direction of 

        // Find the subarray with the highest sum of items
        int[] numsAr = new int[] { 1, 5, -4, 3, 5, 2, 1, 0, 5 };
        public List<IEnumerable<int>> Get_All_Sub_Arrays(int[] nums)
        {
            List<IEnumerable<int>> subArrays = new List<IEnumerable<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                List<int> maxSubArray = nums.Take(i + 1).ToList();

                subArrays.Add(maxSubArray);

                int temp = 1;

                while (temp <= i && temp > 0)
                {
                    subArrays.Add(maxSubArray.Skip(temp).ToList());
                    temp++;
                }
            }
            return subArrays;
        }


        // The above method literally visits and collects every single sub array, the question
        // requires to get every single sub array possible. In Most questions however
        // We will only require to find a sub array that meets a certain condition in which
        // case we wont need to visit every single sub array but we use the Sliding window apprach
        // We start with index left and index right both equal to zero. 
        // Next we move right index to the right untill the condition is met. if condition not met and 
        // rather condition is exceeded, then we move left one step forward and check the condition



        //Given an array of positive integers nums and an integer k, return the number of contiguous
        //subarrays where the product of all the elements in the subarray is strictly less than k.
        int Get_Number_Of_SubArrays(int [] A, int K)
        {
            int p1 = 0;
            int p2 = 0;

            int counter = 0;
            int tempProduct = A[p1];

            while (p2 < A.Length)
            {
                if (tempProduct < K)
                {
                    counter++;
                    p1++;
                }
                else if (tempProduct >= K)
                {
                    p2++;
                }
            }

            return 0;
        }


        //  Given an array of integers greater than zero, find if it is possible to split it in two subarrays
        //  (without reordering the elements),such that the sum of the two subarrays is the same. Print the two subarrays.
        int[] nums = new int[] { 1, 2, 3, 4 };
        bool Array_Can_Be_Split(int[] A)
        {
            int left = 0;
            int leftSum = A[0];

            int right = A.Length - 1;
            int rightSum = A[A.Length - 1];

            while (right - left > 2)
            {
                if (leftSum < rightSum)
                {
                    leftSum += A[++left];
                }
                else if (rightSum < leftSum)
                {
                    rightSum += A[--right];
                }
                else if (leftSum == rightSum)
                {

                    leftSum += A[++left];
                    rightSum += A[--right];
                }
            }

            return leftSum == rightSum;
        }

        //Given an array of both positive and negative integers and a number K.
        //The task is to check if any subarray with product K is present in the array or not
        bool Is_There_Subarray_Multplying_To_K(int[]A, int K)
        {
            int p1 = 0;
            int p2 = 0;

            int multiplier = A[0];

            while (p2 < A.Length-1)
            {
                if (multiplier == K)
                {
                    return true;
                }
                if (multiplier < K && p1 < A.Length-1)
                {
                    multiplier *= A[++p1];
                }
                else if(multiplier > K)
                {
                    multiplier /= A[p2++];          
                }
            }
            return false;
        }


        //https://www.enjoyalgorithms.com/blog/trapping-rain-water
        //https://www.enjoyalgorithms.com/blog/triplet-with-zero-sum
        // Container with most water

    }
}
