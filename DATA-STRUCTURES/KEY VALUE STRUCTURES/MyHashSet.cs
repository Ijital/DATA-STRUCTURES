using System.Collections.Generic;
using System.Diagnostics;

namespace DATA_STRUCTURES.KEY_BASED_STRUCTURES
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


    // HashSet acts likes just like a Dictionary but it only stores keys and not values
    // HashSet also does not allow duplicate keys
    public class MyHashSet
    {
        public MyHashSet()
        {
            Create_HashSet();

            Debugger.Break(); 
        }


        private void Create_HashSet()
        {
            HashSet<int> mySet = new HashSet<int> { 10, 1, 2, 3, 10 };

            Debugger.Break();
        }


    }
}
