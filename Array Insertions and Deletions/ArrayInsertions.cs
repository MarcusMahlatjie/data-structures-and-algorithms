using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    internal class ArrayInsertions
    {
        // Array Insertions and Array Deletions
        int[] intArray = new int[10];

        // make a var to keep the length because .Length is based off capacity and does not track the index
        int length = 0;          

        public void ArrayEndInsertions()
        {
            int length = 0;

            for (int i = 0; i < 8; i++)
            {
                intArray[length] = i + 1;
                length++;
            }

                intArray[length] = 8;
                length++;
        }

        public void ArrayStartInsertions()
        {
            int length = 0;

            for (int i = 0; i < 3; i++)
            {
                intArray[length] = i + 1;
                length++;
            }

            // Inserting at the start of the array 
            for (int i = 3; i >= 0; i--)
            {

                // moving all the elements over by 1
                intArray[i + 1] = intArray[i];
            }

            intArray[0] = 20;
        }

        public void ArrayAnyInsertions()
        {
            int length = 0;

            // Inserting value anywhere in the array (choice of 8 in place of 5 for this eg)
            for (int i = 0; i < 3; i++)
            {
                intArray[length] = i + 1;
                length++;
            }

            for (int i = 4; i >= 2; i--)
            {
                // this shifts each element to the right
                intArray[i + 1] = intArray[i];
            }

            intArray[2] = 8;

        }
    }
}
