using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.Stack
{
    internal class Stack
    {
        public int MaxSize{ get; set; }     // Array stacks need a maxsize to init array
        public string[] stackArray { get; set; }
        public int Top{ get; set; }


        public Stack(int size)
        {
            this.MaxSize = size;

            // create array with size
            this.stackArray = new string[MaxSize];

            // we give the top -1 because array is zero index, otherwise it will skip 1st element
            this.Top = -1;
        }

        public void Push(string item)
        {
            Top++;
            stackArray[Top] = item; 
        }

        public string Pop()
        {
            int oldTop = Top;       // placeholder 
            Top--;
            return stackArray[oldTop];
        }

        public string Peek()
        {
            return stackArray[Top];
        }

        public bool isEmpty()
        {
            return Top == 0;
        }

        public bool isFull()
        {
            return MaxSize - 1 == Top;
        }
    }
}
