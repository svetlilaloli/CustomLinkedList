namespace CustomLinkedList
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Prev { get; internal set; }
        public Node<T> Next { get; internal set; }
        internal Node(T value)
        {
            Value = value;
            Prev = null;
            Next = null;
        }
    }
}
