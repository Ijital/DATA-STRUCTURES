
using System.ComponentModel;

namespace DATA_STRUCTURES.ARRAYS
{
    /// <summary>
    /// These are questions that have to do with the value of two items but also thier 
    /// distance apart. E.g Which two items in an array produce the biggest volume, smallest volume
    /// 
    /// </summary>
    public class TwoItemsAndIndexWidth
    {
        public TwoItemsAndIndexWidth()
        {

        }


        // You are given an integer array heights of length n. There are n vertical lines
        // drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
        // Find two lines that together with the x-axis form a container, such that the container
        // contains the most water. 

        // We can see that this question involves finding the two largest elements that have 
        // The largest distance apart. 
        // Solution:
        // We used two pointers from the farthest points apart i,e from index 0 and  Lenght-2
        // And move to the middle and checking the areas. Pretty much the same way we find the 
        // two elements with the largest sum but rather calculating area instead of sum. i,e at every 
        // iteration we move the smaller value. 
        public int MaxArea(int[] heights)
        {

            if (heights.Length <= 1)
            {
                return 0;
            }

            int leftSide = 0;
            int rightSide = heights.Length - 1;

            int maxVolume = 0;

            while (leftSide != rightSide)
            {
                int distanceApart = rightSide - leftSide;

                int shorterHeight = heights[leftSide] < heights[rightSide] ? heights[leftSide] : heights[rightSide];

                int volume = distanceApart * shorterHeight;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                }

                if (heights[leftSide] < heights[rightSide])
                {
                    leftSide++;
                }
                else
                {

                    rightSide--;
                }

            }
            return maxVolume;
        }


    }
}
