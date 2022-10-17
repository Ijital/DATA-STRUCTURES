using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURES.KEY_VALUE_STRUCTURES
{
    public class MySortedSet
    {
        public MySortedSet()
        {
            Create_Sorted_Set();
            Debugger.Break();
        }

        void Create_Sorted_Set()
        {

            SortedSet<int> numSet = new SortedSet<int>();

            numSet.Add(1);

            numSet.Add(2);

            numSet.Add(1);


        }
      
    }
}
