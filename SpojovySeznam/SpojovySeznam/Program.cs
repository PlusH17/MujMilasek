using System.ComponentModel;

namespace SpojovySeznam;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Node
{
    public Node(int value)
    {
        Value = value;
    }

    public int Value { get; }
    public Node Next { get; set; }

}

class LinkedLsit
{
    public Node Head { get; set; }

    public void Add (int value)
    {
        if (Head == null)
            Head = new Node (value);
        else
        {
            Node newNode = new Node (value);
            newNode.Next = Head;
            Head = newNode;
        }


    }
    public bool Find (int value)
    {

        Node node = Head;
        while (node != null)
        {
            if (node.Next.Value == value)
                return true;
            node = node.Next;
        }
        return false;
}
