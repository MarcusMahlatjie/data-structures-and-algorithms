using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    internal class LinearSearch
    {
        // Linear Search Algorithm
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // key is basically the valule that we are searching for
        public bool LinearSearchMethod(int[] array, int key)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (arr[i] == key)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
