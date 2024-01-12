using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.Queue
{
    internal class Queue
    {
        public int MaxSize { get; set; }
        public int[] QueueArray { get; set; }
        public int Front { get; set; }
        public int Rear { get; set; }
        public int ItemPointer { get; set; }

        public Queue(int size)
        {
            MaxSize = size;
            QueueArray = new int[size];
            Front = 0;
            Rear = -1;
            ItemPointer = 0;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full. Cannot enqueue.");
                return;
            }

            Rear = (Rear + 1) % MaxSize;
            QueueArray[Rear] = item;
            ItemPointer++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot dequeue.");
                return -1; // Return a default value (you can choose another approach)
            }

            int temp = QueueArray[Front];
            Front = (Front + 1) % MaxSize;
            ItemPointer--;
            return temp;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot peek.");
                return -1;                  // Return a default value (you can choose another approach)
            }

            return QueueArray[Front];
        }

        public bool IsEmpty()
        {
            return ItemPointer == 0;
        }

        public bool IsFull()
        {
            return ItemPointer == MaxSize;
        }
    }
}
