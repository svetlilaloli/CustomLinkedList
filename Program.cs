using System;

namespace CustomLinkedList
{
    public class Program
    {
        public static void Main()
        {
            var myList = new LinkedList<int>();

            for (int i = 0; i < 5; i++)
            {
                myList.PushFirst(i);
            }
            for (int i = 10; i < 15; i++)
            {
                myList.PushLast(i);
            }
            myList.PopFirst();
            myList.PopLast();
            myList.Remove(myList[4]);
            myList.InsertAfter(myList.Last, 100);
            myList.InsertBefore(myList.First, 100);
            myList.InsertAfter(myList.First, 1000);
            myList.InsertBefore(myList.Last, 1000);

            foreach (Node<int> node in myList)
            {
                Console.WriteLine(node.Value);
            }
        }
    }
}
