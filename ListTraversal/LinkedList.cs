using System;
using System.Collections;
using System.Collections.Generic;

class LinkedList<T> : IEnumerable<T>
{
    private class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node head;
    public int Count { get; private set; }

    public LinkedList()
    {
        head = null;
        Count = 0;
    }

    public void Add(T value)
    {
        if (head == null)
        {
            head = new Node(value);
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(value);
        }
        Count++;
    }

    public bool Remove(T value)
    {
        if (head == null)
        {
            return false;
        }

        if (head.Value.Equals(value))
        {
            head = head.Next;
            Count--;
            return true;
        }

        Node current = head;
        while (current.Next != null)
        {
            if (current.Next.Value.Equals(value))
            {
                current.Next = current.Next.Next;
                Count--;
                return true;
            }
            current = current.Next;
        }

        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
