namespace GenericTypes;

// Make a class stub for a generic Linked list (specify methods, don't implement), that supports
// adding an item
// removing an item
// getting the count of items
// getting an item at a specified index
// include nested node structure

public class LinkedList<T> where T : class, IMyInterface
{
    class Node
    {
        public T Value;
        public Node next;
    }
    public int Count { get; private set; }
    public void Add(T item)
    {
        Node node = new Node();
        node.Value = item;
    }
    public void Remove(T item) { }
    public T Get(int index) { return default(T); }
}

public interface IMyInterface
{
    public void Method();
}