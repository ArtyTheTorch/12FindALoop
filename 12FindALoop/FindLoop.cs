using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12FindALoop
{
    class FindLoop
    {
        LinkedList<object> list = new LinkedList<object>();
        public FindLoop() {
            int[] sampleData = {1,2,3,4,5,6,7,8,9,10};
            foreach (int i in sampleData) {
                list.AddFirst(i);
            }
            //list.Last = list.First;
            // I need to create a loop in the linked list somewhere here...
        }
        public string hasLoop()
        {
            // This should be the correct algorithm that detects the loop
            // It is commonly refered to as the Tortoise and Hare Algorithm
            LinkedListNode<object> slowNode = list.First;
            LinkedListNode<object> fastNode1 = list.First;
            LinkedListNode<object> fastNode2 = list.First;

            while (slowNode != null && fastNode1 == fastNode2.Next && fastNode2 == fastNode1.Next)
            {
                if (slowNode == fastNode1 || slowNode == fastNode2)
                {
                    return "True";
                }
                slowNode = slowNode.Next;
            }
            return "False";
        }
    }
}
