using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_structures_and_algorithms.LinkedList;

namespace data_structures_and_algorithms.LinkedList
{
      class LinkedList
    {
        public Node First { get; set; }
        public void InsertFirst(int data)
        {
            // create the node
            Node newNode = new Node();
            
            newNode.Data = data;     // insert data in node

            newNode.Next = First;   // put the old node in the next

            First = newNode;        // make the first the new node 
        }

        public Node DeleteFirst()
        {
            // assign temp var
            Node temp = First;

            First = First.Next; // assign the next head

            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating through list...");
            Node current = First;       // we asign a new first because we don't want to tamper with the original data

            while (current != null)     // the last value in a LinkedList is null, so this loop will iterate until we get to that last value
            {
                current.DisplayNode();
                current = current.Next;
            }
        }
    }
}
