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
            var result = Get_First_Recurring_Value(Data.ArrayA);

            var result1 = Find_The_Item_Occuring_Once(nums);

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

    }
}
