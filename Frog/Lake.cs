using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Lake : IEnumerable<int>
{
    private readonly List<int> stones;

    public Lake(IEnumerable<int> stones)
    {
        this.stones = stones.ToList();
    }

    public IEnumerator<int> GetEnumerator()
    {
        var evenStones = stones.Where((s, index) => (index + 1) % 2 == 0);
        var oddStones = stones.Where((s, index) => (index + 1) % 2 != 0).Reverse();
        foreach (var stone in evenStones.Concat(oddStones))
        {
            yield return stone;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}