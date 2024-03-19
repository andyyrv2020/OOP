using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IEnumerable<T>
{
    private List<T> collection;
    private int currentIndex;

    public ListyIterator(IEnumerable<T> collection)
    {
        this.collection = new List<T>(collection);
        this.currentIndex = 0;
    }

    public bool Move()
    {
        if (this.HasNext())
        {
            this.currentIndex++;
            return true;
        }
        return false;
    }

    public bool HasNext()
    {
        return this.currentIndex < this.collection.Count - 1;
    }

    public void Print()
    {
        if (this.collection.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        Console.WriteLine(this.collection[this.currentIndex]);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in collection)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}