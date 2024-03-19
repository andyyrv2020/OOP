using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Stack<T> : IEnumerable<T>
{
    private List<T> elements;

    public Stack()
    {
        this.elements = new List<T>();
    }

    public void Push(T element)
    {
        this.elements.Add(element);
    }

    public T Pop()
    {
        if (this.elements.Count == 0)
        {
            throw new InvalidOperationException("No elements");
        }

        T poppedElement = this.elements.Last();
        this.elements.RemoveAt(this.elements.Count - 1);
        return poppedElement;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.elements.Count - 1; i >= 0; i--)
        {
            yield return this.elements[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}