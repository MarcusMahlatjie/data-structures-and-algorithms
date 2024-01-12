using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.BinarySearch
{
    internal class BinarySearch
    {
        public int BinarySearchMethod(int[] array, int value)
        {
            int start = 0;
            int end = array.Length;

            while (start < end)
            {
                int midpoint = (start + end) / 2;

                if (array[midpoint] == value)
                {
                    return midpoint;
                }

                else if (array[midpoint] < value)
                {
                    start = midpoint + 1;
                }

                else if (array[midpoint] > value)
                {
                    end = midpoint;
                }
            }

            return -1;
        }
    }
}
