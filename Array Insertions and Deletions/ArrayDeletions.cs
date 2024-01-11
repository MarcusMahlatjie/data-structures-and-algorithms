using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    internal class ArrayDeletions
    {
        int[] intArray = new int[9];
        public void ArrayEndDeletions()
        {
            // arrays are of a fixed size therefore you cannot completely delete the placeholder fpr a value,
            // instead we removw the value at that index

            int length = 0;

            for (int i = 0; i < 6; i++)
            {
                intArray[length] = i;
                length++;
            }

            length--;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }

        public void ArrayStartDeletions()
        {
            // arrays are of a fixed size therefore you cannot completely delete the placeholder fpr a value,
            // instead we removw the value at that index

            int length = 0;

            for (int i = 0; i < 6; i++)
            {
                intArray[length] = i;
                length++;
            }

            for (int i = 1; i > length; i++)
            {
                intArray[i - 1] = intArray[i];
            }
            length--;
        }

        public void ArrayAnyDeletions()
        {
            // arrays are of a fixed size therefore you cannot completely delete the placeholder fpr a value,
            // instead we removw the value at that index

            int length = 0;

            for (int i = 0; i < 6; i++)
            {
                intArray[length] = i;
                length++;
            }

            for (int i = 2; i < length; i++)
            {
                intArray[i - 1] =  intArray[i];
            }
            length--;
        }
    }
}
