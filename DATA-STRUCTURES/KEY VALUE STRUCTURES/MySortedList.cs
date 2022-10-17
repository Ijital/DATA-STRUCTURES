
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DATA_STRUCTURES.KEY_VALUE_STRUCTURES
{
    // The HashSet Data structure has the following time complexity
    //  ==============================================================
    //  this[key]........................................O(1)
    //  this.Add(key, value) ............................O(1) or O(N)
    //  this.Remove(key)................................ O(1)   
    //  this.ContainsKey(key)............................O(1)  
    //  this.ContainsValue(value)........................O(N)
    //  this.TryGetValue(T key, K out value).............O(1)
    //  ==================================================================

    // Sorted List acts just like Dictionary, fast loop up. The difference is that it sorts
    // the collection is sorted by key.
    // Like Dictionary, its does not allow mutiple keys
    public class MySortedList
    {
        public MySortedList()
        {

            Create_Sorted_List();

            Debugger.Break();   
        }


        private void Create_Sorted_List()
        {
            SortedList<string, int> phoneNums = new SortedList<string, int>()
            {
                {"Melvin", 123 },
                {"Hannah", 212 },
                {"Alia", 232 },
            };
           
            Debugger.Break();

        }

    }
}
