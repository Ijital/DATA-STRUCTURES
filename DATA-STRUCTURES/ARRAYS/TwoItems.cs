
using System.Diagnostics;

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
    }
}
