namespace CustomLinkedList
{
    public class LinkedList<T>
    {
        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }
        public int Count { get; private set; }
        public LinkedList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public void PushFirst(T value)
        {
            if (First == null)
            {
                First = Last = new Node<T>(value);
                Count++;
                return;
            }
            InsertBefore(First, value);
        }
        public void PushLast(T value)
        {
            if (Last == null)
            {
                First = Last = new Node<T>(value);
                Count++;
                return;
            }
            InsertAfter(Last, value);
        }
        public void InsertBefore(Node<T> node, T value)
        {
            Node<T> newNode = new Node<T>(value)
            {
                Next = node,
                Prev = node.Prev
            };
            if (node.Prev != null)
            {
                node.Prev.Next = newNode;
            }
            else
            {
                First = newNode;
            }
            node.Prev = newNode;
            Count++;
        }
        public void InsertAfter(Node<T> node, T value)
        {
            Node<T> newNode = new Node<T>(value)
            {
                Next = node.Next,
                Prev = node
            };
            if (node.Next != null)
            {
                node.Next.Prev = newNode;
            }
            else
            {
                Last = newNode;
            }
            node.Next = newNode;
            Count++;
        }
        public void PopFirst()
        {
            Remove(First);
        }
        public void PopLast()
        {
            Remove(Last);
        }
        public void Remove(Node<T> node)
        {
            if (node.Prev != null)
            {
                node.Prev.Next = node.Next;
            }
            else
            {
                First = node.Next;
            }
            if (node.Next != null)
            {
                node.Next.Prev = node.Prev;
            }
            else
            {
                Last = node.Prev;
            }
            Count--;
        }
        public Node<T> this[int index]
        {
            get {
                Node<T> node = First;
                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }
                return node; 
            }
        }
    }
}
