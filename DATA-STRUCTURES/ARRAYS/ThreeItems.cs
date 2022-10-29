
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DATA_STRUCTURES.ARRAYS
{
    public class ThreeItems
    {
        public ThreeItems()
        {
           var newArry =  Get_Three_Items_Summing(X);


            Debugger.Break();

        }

        // Given an array of distinct integers, find all triplets in the array that sum up to 0;
        // This is similar to finding two numbers that sum up to a target value only that
        // here we loop through each item and for each item we find two other itmems that 
        // sum up to it 

        // Solution: 
        // Step 1   Sort the array. The normal sorting has an acceptable Big O of O(NlogN)
        // Step 2   Loop through the sorted array. For each item T, use two pointers technique 
        //          i.e to find two items that add up to -T
        // Step 3   Move to the next item and repeat step 1 and 2

        int[] X = { 0, -2, 5, -3, 2 };

       // Output: [0, -2, 2] and[-2, 5, -3]
        List<List<int>> Get_Three_Items_Summing(int[] A)
        {
            Array.Sort(A);

            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < A.Length; i++)
            {
                int leftPointer = 0;

                int rightPointer = A.Length - 1;

                while (rightPointer - leftPointer > 1)
                {
                    int tempSum = A[leftPointer] + A[rightPointer] + A[i];

                    if (tempSum == 0)
                    {
                        result.Add(new List<int> { A[leftPointer], A[rightPointer], A[i] });
                        break;
                    }
                    else if (tempSum > 0)
                    {
                        rightPointer--;
                    }
                    else if (tempSum < 0)
                    {
                        leftPointer++;
                    }
                }
            }
            return result;
        }
    }
}
